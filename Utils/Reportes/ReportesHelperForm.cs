using MaterialSkin;
using MaterialSkin.Controls;
using p_proyect.Modules.Entidades.dtos.dtoUsuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace p_proyect.Utils.Reportes
{
    public partial class ReportesHelperForm : MaterialForm
    {

        public List<UsuarioMostrarDto> ListadoParaImprimirUsuarios = new List<UsuarioMostrarDto>();
        public List<UsuarioMostrarDto> ListadoParaImprimirUsuarios_Copia = new List<UsuarioMostrarDto>();
        public ReportesHelperForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // Fondos blancos
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Tema rojizo empresarial
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red800,   // Color principal (barra superior)
                Primary.Red900,   // Dark Primary
                Primary.Red700,   // Light Primary
                Accent.Red200,    // Acento (buttons, sliders)
                TextShade.WHITE   // Color del texto de la barra
            );
        }

        public void CargarListaParaReporte()
        {
            if (ListadoParaImprimirUsuarios != null)
            {
                ListadoParaImprimirUsuarios_Copia = ListadoParaImprimirUsuarios;
                ListadoParaReportesShow.DataSource = ListadoParaImprimirUsuarios;
                return;
            }
        }


        private void ReportesHelperForm_Load(object sender, EventArgs e)
        {
            CargarListaParaReporte();
        }
        private void GenerarReportesUsuarios()
        {
            if (ListadoParaImprimirUsuarios == null || ListadoParaImprimirUsuarios.Count == 0)
                return;

            var respuesta = MessageBox.Show("Estas seguro de que quieres generar un reporte de Usuarios?", "Generar reporte?", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }
            List<string> nombresPropiedades = new List<string>
                {
                    "Id",
                    "Nombre",
                    "Apellido",
                    "Cedula",
                    "Correo",
                    "Rol",
                    "Activo",
                    "FechaCreacion",
                    "FechaEdicion",
                    "UltimaVezActivo"
                };



            GeneradorDePdf.GeneradorDePDFS<UsuarioMostrarDto>(
             ListadoParaImprimirUsuarios,
             nombresPropiedades,
             "Usuarios",
             "ReportesPlantilla",
             "ReporteUsuarios"
              );

            MessageBox.Show("Reporte generado con exito");
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            GenerarReportesUsuarios();
        }
        public static List<T> FiltrarPorRangoDeFechas<T>(List<T> datos, DateTime fechaInicio, DateTime fechaFin) where T : class
        {
            return datos
                .Where(x =>
                {
                    var prop = typeof(T).GetProperty("FechaCreacion");
                    if (prop == null) return false;

                    var valor = prop.GetValue(x);
                    if (valor == null) return false;

                    DateTime fecha = (DateTime)valor;
                    return fecha >= fechaInicio && fecha <= fechaFin;
                })
                .ToList();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            GenerarReportesUsuarios();
        }

        private void CargarPorFechasUsuarios()
        {
            var filtrados = FiltrarPorRangoDeFechas<UsuarioMostrarDto>(
                 ListadoParaImprimirUsuarios,
                 FechaDeInicioDelReporte.Value,
                 FechaDeFinalizacionDelReporte.Value
              );

            ListadoParaReportesShow.DataSource = null;

            ListadoParaReportesShow.DataSource = filtrados;
            return;
        }

        private void cargarPorfechas()
        {
            if (ListadoParaImprimirUsuarios != null)
            {
                CargarPorFechasUsuarios();
            }
        }


        private void FechaDeInicioDelReporte_ValueChanged(object sender, EventArgs e)
        {
            cargarPorfechas();
        }

        private void FechaDeFinalizacionDelReporte_ValueChanged(object sender, EventArgs e)
        {
            cargarPorfechas();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            if(ListadoParaImprimirUsuarios != null)
            {
                ListadoParaImprimirUsuarios = ListadoParaImprimirUsuarios_Copia;
                ListadoParaReportesShow.DataSource = null;
                ListadoParaReportesShow.DataSource = ListadoParaImprimirUsuarios;
            }
        }
    }
}
