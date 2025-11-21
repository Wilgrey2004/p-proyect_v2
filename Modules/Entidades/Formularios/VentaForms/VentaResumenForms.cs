using MaterialSkin;
using MaterialSkin.Controls;
using p_proyect.Modules.Entidades.Formularios.AdeudosForms;
using System;
using System.Windows.Forms;

namespace p_proyect.Modules.Entidades.Formularios.VentaForms
{
    public partial class VentaResumenForms : MaterialForm
    {

        public Ventas VentaActual = new Ventas();
        public VentaResumenForms()
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

        private void VentaResumenForms_Load(object sender, EventArgs e)
        {
            if (VentaActual == null)
            {
                Confirmacion = false;
                Close();
            }
            CargarCompra();


        }

        private void CargarCompra()
        {
            DescuentoAplicado.Text = VentaActual.Descuento.ToString();
            TotalDeLaVenta.Text = VentaActual.TotalEntero.ToString();
            MontoDescontadodeLaCantidadTotal.Text = VentaActual.MontoDescontado.ToString();
            TotalDescontado.Text = VentaActual.TotalConElDescuento.ToString();
            FechaDeLaventa.Text = VentaActual.FechaCreacion.ToString();
            CantidadDelProducto.Text = VentaActual.ListadoDeCompras.Count.ToString();
        }

        public bool Confirmacion = false;
        private void materialButton1_Click(object sender, EventArgs e)
        {
            Confirmacion = false;

            Close();
        }

        private void Agregar_usuarios_Click(object sender, EventArgs e)
        {
            Confirmacion = true;

            Close();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            try
            {
                decimal montoPagado = decimal.Parse(DineroDelCliente.Text);
                decimal total = VentaActual.TotalEntero;

                decimal devuelta = montoPagado - total;

                DevueltaDelCliente.Text = devuelta.ToString("N2");

                if(devuelta < 0)
                {
                    var respuesta = MessageBox.Show("Generar un adeudo?", "Quieres Generar Un Adeudo apra el cliente?", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.No)
                    {
                        return;
                    }
                    AgrearAdeudoParaUnClienteNormal generarAdeudoCliente = new AgrearAdeudoParaUnClienteNormal();

                    generarAdeudoCliente.ventaActual = VentaActual;

                    generarAdeudoCliente.montoDelAdeudo = decimal.Parse(DevueltaDelCliente.Text);

                    generarAdeudoCliente.ShowDialog();



                    MessageBox.Show("Adeudo Generado!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en el cálculo de la venta\n" + ex.Message);
            }
        }

    }
}

