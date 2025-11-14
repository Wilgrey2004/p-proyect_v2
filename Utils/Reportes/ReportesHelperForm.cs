using MaterialSkin;
using MaterialSkin.Controls;
using p_proyect.Modules.Entidades.dtos.dtoProductos;
using p_proyect.Modules.Entidades.dtos.dtoProveedor;
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

        public List<ProductoMostrarDto> ListadoParaImprimirProductos = new List<ProductoMostrarDto>();
        public List<ProductoMostrarDto> ListadoParaImprimirProductos_Copia = new List<ProductoMostrarDto>();

        public List<ProveedorMostrarDto> ListadoParaImprimirProveedor = new List<ProveedorMostrarDto>();
        public List<ProveedorMostrarDto> ListadoParaImprimirProveedor_Copia = new List<ProveedorMostrarDto>();
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
            if (ListadoParaImprimirUsuarios != null && ListadoParaImprimirUsuarios.Count > 0)
            {
                ListadoParaImprimirUsuarios_Copia = new List<UsuarioMostrarDto>(ListadoParaImprimirUsuarios);
                ListadoParaReportesShow.DataSource = ListadoParaImprimirUsuarios;
                return;
            }

            if (ListadoParaImprimirProductos != null && ListadoParaImprimirProductos.Count > 0)
            {
                ListadoParaImprimirProductos_Copia = new List<ProductoMostrarDto>(ListadoParaImprimirProductos);
                ListadoParaReportesShow.DataSource = ListadoParaImprimirProductos;
                return;
            }

            if (ListadoParaImprimirProveedor != null && ListadoParaImprimirProveedor.Count > 0)
            {
                ListadoParaImprimirProveedor_Copia = new List<ProveedorMostrarDto>(ListadoParaImprimirProveedor);
                ListadoParaReportesShow.DataSource = ListadoParaImprimirProveedor;
                return;
            }
        }
        private void GenerarReportesProductos()
        {
            if (ListadoParaImprimirProductos == null || ListadoParaImprimirProductos.Count == 0)
                return;

            var respuesta = MessageBox.Show("¿Estás seguro de que quieres generar un reporte de Productos?",
                                            "Generar reporte", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.No)
                return;

            List<string> nombresPropiedades = new List<string>
            {
                "Id",
                "Nombre",
                "Descripcion",
                "CodigoBarra",
                "Marca",
                "Modelo",
                "Cantidad",
                "PrecioCompra",
                "PrecioVenta",
                "Ubicacion",
                "UnidadMedida",
                "TipoDeDeSalida",
                "ProveedorNombre",
                "FechaExpiracion",
                "FechaCreacion"
            };

            GeneradorDePdf.GeneradorDePDFS<ProductoMostrarDto>(
                ListadoParaImprimirProductos,
                nombresPropiedades,
                "Productos",
                "ReportesPlantilla",
                "ReporteProductos"
            );

            MessageBox.Show("Reporte de productos generado con éxito ✅");
        }
        private void CargarPorFechasProductos()
        {
            var filtrados = FiltrarPorRangoDeFechas<ProductoMostrarDto>(
                ListadoParaImprimirProductos,
                FechaDeInicioDelReporte.Value,
                FechaDeFinalizacionDelReporte.Value
            );

            ListadoParaReportesShow.DataSource = null;
            ListadoParaReportesShow.DataSource = filtrados;
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

        private void GenerarReportesProveedores()
        {
            if (ListadoParaImprimirProveedor == null || ListadoParaImprimirProveedor.Count == 0)
                return;

            var respuesta = MessageBox.Show("Estas seguro de que quieres generar un reporte de Proveedores?", "Generar reporte?", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }
            List<string> nombresPropiedades = new List<string>
                {
                   "Codigo unico",
                   "Nombre",
                   "Numero de Telefono",
                   "Ultima compra",
                   "Fecha de creacion"
                };



            GeneradorDePdf.GeneradorDePDFS<ProveedorMostrarDto>(
             ListadoParaImprimirProveedor,
             nombresPropiedades,
             "Proveedores",
             "ReportesPlantilla",
             "Reporte_De_Proveedores"
              );

            MessageBox.Show("Reporte generado con exito");
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (ListadoParaImprimirUsuarios != null && ListadoParaImprimirUsuarios.Count > 0) { GenerarReportesUsuarios(); return; }

            if (ListadoParaImprimirProductos != null && ListadoParaImprimirProductos.Count > 0) { GenerarReportesProductos(); return; }

            if (ListadoParaImprimirProveedor != null && ListadoParaImprimirProveedor.Count > 0) { GenerarReportesProveedores(); return; }
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
            if (ListadoParaImprimirUsuarios != null)
            {
                GenerarReportesUsuarios();
                return;
            }

            if (ListadoParaImprimirProductos != null)
            {
                GenerarReportesProductos();
                return;
            }

            if (ListadoParaImprimirProveedor != null)
            {
                GenerarReportesProveedores();
                return;
            }
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
            if (ListadoParaImprimirUsuarios != null && ListadoParaImprimirUsuarios.Count > 0)
            {
                CargarPorFechasUsuarios();
                return;
            }
            else if (ListadoParaImprimirProductos != null && ListadoParaImprimirProductos.Count > 0)
            {
                CargarPorFechasProductos();
                return;
            }
            else if (ListadoParaImprimirProveedor != null && ListadoParaImprimirProveedor.Count > 0)
            {
                CargarPorFechasProveedores();
                return;
            }
        }



        private void CargarPorFechasProveedores()
        {
            var filtrados = FiltrarPorRangoDeFechas<ProveedorMostrarDto>(
                     ListadoParaImprimirProveedor,
                     FechaDeInicioDelReporte.Value,
                     FechaDeFinalizacionDelReporte.Value
                  );
            ListadoParaReportesShow.DataSource = null;
            ListadoParaReportesShow.DataSource = filtrados;
            return;
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
            if (ListadoParaImprimirUsuarios != null && ListadoParaImprimirUsuarios.Count > 0)
            {
                ListadoParaImprimirUsuarios = new List<UsuarioMostrarDto>(ListadoParaImprimirUsuarios_Copia);
                ListadoParaReportesShow.DataSource = null;
                ListadoParaReportesShow.DataSource = ListadoParaImprimirUsuarios;
            }
            else if (ListadoParaImprimirProductos != null && ListadoParaImprimirProductos.Count > 0)
            {
                ListadoParaImprimirProductos = new List<ProductoMostrarDto>(ListadoParaImprimirProductos_Copia);
                ListadoParaReportesShow.DataSource = null;
                ListadoParaReportesShow.DataSource = ListadoParaImprimirProductos;
            }
            else if (ListadoParaImprimirProveedor != null && ListadoParaImprimirProveedor.Count > 0)
            {
                ListadoParaImprimirProveedor = new List<ProveedorMostrarDto>(ListadoParaImprimirProveedor_Copia);
                ListadoParaReportesShow.DataSource = null;
                ListadoParaReportesShow.DataSource = ListadoParaImprimirProveedor;
            }
        }

    }
}
