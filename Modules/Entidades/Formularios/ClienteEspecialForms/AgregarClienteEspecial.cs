using MaterialSkin;
using MaterialSkin.Controls;
using p_proyect.Controller.ClienteEspecialController;
using p_proyect.Modules.Entidades.dtos.dtoClienteEspecial;
using System;
using System.Windows.Forms;

namespace p_proyect.Modules.Entidades.Formularios.ClienteEspecialForms
{
    public partial class AgregarClienteEspecial : MaterialForm
    {
        public AgregarClienteEspecial()
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

        private void AgregarClienteEspecial_Load(object sender, EventArgs e)
        {
            Text = "Agrgar Cliente Especial";
        }

        ClienteEspecialControllerC ClienteEspecialControllerC_ = new ClienteEspecialControllerC();


        private ClienteEspecialCrearDto ObtenerDatosFormulario()
        {
            var clienteEspecialDto = new ClienteEspecialCrearDto
            {
                Nombre = Nombre_txt.Text,
                Apellido = Apellido_txt.Text,
                Cedula = Cedula_txt.Text,
                Contacto = Contacto_txt.Text,
                LimiteDelCredito = decimal.Parse(LimiteDeCredito_txt.Text),
                DescuentoPersonal = decimal.Parse(Descuento_txt.Text)
            };
            return clienteEspecialDto;
        }


        private async void Agregar_usuarios_Click(object sender, EventArgs e)

        {

           var clienteCreado = await ClienteEspecialControllerC_.CrearClienteEspecialAsync(ObtenerDatosFormulario());

            if (clienteCreado != null)
              {
                MessageBox.Show("Cliente Especial agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
              }
              else
              {
                MessageBox.Show("Error al agregar el Cliente Especial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
