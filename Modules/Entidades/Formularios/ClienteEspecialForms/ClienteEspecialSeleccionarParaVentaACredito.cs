using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using p_proyect.Controller.ClienteEspecialController;
using p_proyect.Modules.Entidades.dtos.dtoClienteEspecial;
using p_proyect.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace p_proyect.Modules.Entidades.Formularios.ClienteEspecialForms
{
    public partial class ClienteEspecialSeleccionarParaVentaACredito : MaterialForm
    {
        public Ventas VentaActual = new Ventas();
        public bool Confirmacion = false;
        public ClienteEspecialSeleccionarParaVentaACredito(Ventas venta)
        {
            VentaActual = venta;

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


        ClienteEspecialControllerC clienteC = new ClienteEspecialControllerC();
        List<ClienteEspecialMostrarDto> clienteEspecialListado = new List<ClienteEspecialMostrarDto>();
        private async void CargarTablaCLienteEspecial()
        {
            clienteEspecialListado.Clear();
            ListadoDeClienteEspeciales.DataSource = null;

            clienteEspecialListado = await clienteC.ObtenerTodosLosClientesEspecialesAsync(); 

            ListadoDeClienteEspeciales.DataSource = clienteEspecialListado;
        }

        private void ClienteEspecialSeleccionarParaVentaACredito_Load(object sender, EventArgs e)
        {
            MontoDeLaVenta.ReadOnly = true;
            MontoDeLaVenta.Text = VentaActual.TotalEntero.ToString();
            CargarTablaCLienteEspecial(); 
        }
        int idClienteEspecial = -1;

        public ClienteEspecial ClienteEspecialSeleccionado;

        private void CargarComboConInforDelCliente(ClienteEspecial cliente)
        {
            NombreDelCliente.Text = cliente.Nombre;
            CreditoRestanteDelCliente.Text = cliente.CreditoDisponible.ToString();
        }
        


        private async void ListadoDeClienteEspeciales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idClienteEspecial = DataGridHelper.ObtenerIdSeleccionado(ListadoDeClienteEspeciales, e);

            if (idClienteEspecial != -1)
            {
                using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
                {
                    ClienteEspecialSeleccionado = await context.ClientesEspeciales.FirstOrDefaultAsync(x => x.Id == idClienteEspecial);

                    if (ClienteEspecialSeleccionado != null)
                    {
                        CargarComboConInforDelCliente(ClienteEspecialSeleccionado);
                        return;
                    }

                }
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Agregar_usuarios_Click(object sender, EventArgs e)
        {
            if(ClienteEspecialSeleccionado == null)
            {
                MessageBox.Show("Selecciona aun cliente especial");
                return;
            }

            var respuesta = MessageBox.Show("Generar Venta A Credito Con cliente especial?", "Pregunta sobre agregado", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                ClienteEspecialSeleccionado.CreditoGastado +=  VentaActual.TotalConElDescuento;

                context.ClientesEspeciales.Update(ClienteEspecialSeleccionado);

                context.SaveChanges();

                Confirmacion = true;

            }

            Close();

        }
    }
}
