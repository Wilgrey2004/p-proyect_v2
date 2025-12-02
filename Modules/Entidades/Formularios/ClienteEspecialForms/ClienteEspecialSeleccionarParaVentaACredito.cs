using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using p_proyect.Controller.ClienteEspecialController;
using p_proyect.Modules.Entidades.dtos.dtoAdeudos;
using p_proyect.Modules.Entidades.dtos.dtoClienteEspecial;
using p_proyect.Utils;
using System;
using System.Collections.Generic;
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
            if (ClienteEspecialSeleccionado == null)
            {
                MessageBox.Show("Selecciona aun cliente especial");
                return;
            }

            if (ClienteEspecialSeleccionado.CreditoDisponible < VentaActual.TotalConElDescuento)
            {
                MessageBox.Show("El cliente especial no tiene suficiente credito disponible para esta venta.");
                return;
            }

            var respuesta = MessageBox.Show("Generar Venta A Credito Con cliente especial?", "Pregunta sobre agregado", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.No)
            {
                return;
            }

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {

                AdeudoCrearDto adeudo = new AdeudoCrearDto
                {
                    MontoTotalDelAdeudo = VentaActual.TotalConElDescuento,
                    MontoTotalAbonadoDelAdeudo = 0,
                    //MontoRestanteDelAdeudo = VentaActual.TotalConElDescuento,
                    FechaCreacion = DateTime.Now,
                    // FechaUltimaActualizacion = DateTime.Now,
                    IdVenta = VentaActual.Id,
                    IdCliente = ClienteEspecialSeleccionado.Id,
                    ContactoDelCliente = ClienteEspecialSeleccionado.Contacto
                };

                context.Ventas.Add(VentaActual);

                context.SaveChanges();

                //Ventas venta =context.Ventas.OrderByDescending(v => v.Id).FirstOrDefault();

                adeudo.IdVenta = VentaActual.Id;

                context.Adeudos.Add(AdeudoMapper.ToEntity(adeudo));

                ClienteEspecialSeleccionado.CreditoGastado += VentaActual.TotalConElDescuento;

                context.ClientesEspeciales.Update(ClienteEspecialSeleccionado);

                context.SaveChanges();

                Confirmacion = true;

            }

            Close();

        }

        private void BuscarPorNombre_TextChanged(object sender, EventArgs e)
        {
            FindForNameHelper.BuscarPorNombre<ClienteEspecialMostrarDto>(sender, e, clienteEspecialListado, ListadoDeClienteEspeciales);
        }
    }
}
