using MaterialSkin;
using MaterialSkin.Controls;
using p_proyect.Controller.ClienteEspecialController;
using p_proyect.Modules.Entidades.dtos.dtoClienteEspecial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_proyect.Modules.Entidades.Formularios.ClienteEspecialForms
{
    public partial class ClienteEspecialEditar : MaterialForm
    {

        public ClienteEspecial clienteEspecial = new ClienteEspecial();
        public ClienteEspecialEditar()
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


        private void CargarInformacionDelCliente(ClienteEspecial clienteEspecial)
        {
            Nombre_txt.Text = clienteEspecial.Nombre;
            Apellido_txt.Text = clienteEspecial.Apellido;
            Cedula_txt.Text = clienteEspecial.Cedula;
            Contacto_txt.Text = clienteEspecial.Contacto;
            Descuento_txt.Text = clienteEspecial.DescuentoPersonal.ToString().Trim();
            LimiteDeCredito_txt.Text = clienteEspecial.LimiteDelCredito.ToString().Trim();
            Creditogastado_txt.Text = clienteEspecial.CreditoGastado.ToString().Trim();
            CreditoDisponible_txt.Text = clienteEspecial.CreditoDisponible.ToString().Trim();

        }


        private void ClienteEspecialEditar_Load(object sender, EventArgs e)
        {
            Text = $"Estas Editando al cliente especial {clienteEspecial.Nombre}";
            
            CargarInformacionDelCliente(clienteEspecial);

        }
        private ClienteEspecialEditarDto CrearClienteEspecialEditarDto()
        {
            return new ClienteEspecialEditarDto
            {
                Id = clienteEspecial.Id,
                Nombre = Nombre_txt.Text.Trim(),
                Apellido = Apellido_txt.Text.Trim(),
                Cedula = Cedula_txt.Text.Trim(),
                Contacto = Contacto_txt.Text.Trim(),
                DescuentoPersonal = Convert.ToDecimal(Descuento_txt.Text.Trim()),
                LimiteDelCredito = Convert.ToDecimal(LimiteDeCredito_txt.Text.Trim()),
                CreditoGastado = Convert.ToDecimal(Creditogastado_txt.Text.Trim()),
                CreditoDisponible = Convert.ToDecimal(CreditoDisponible_txt.Text.Trim())
            };
        }

        ClienteEspecialControllerC ClienteEspecialControllerC_ = new ClienteEspecialControllerC();
        private async void Agregar_usuarios_Click(object sender, EventArgs e)
        {

            var respuesta = MessageBox.Show("Queres Editar a este cliente?", "Pregunta sobre Edicion", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }

            var clienteEspecialEditado = await ClienteEspecialControllerC_.EditarClienteEspecialAsync(CrearClienteEspecialEditarDto());

            if (clienteEspecialEditado != null)
            {

                MessageBox.Show("Cliente editado con exito");
                Close();

            }
            else 
            {
                MessageBox.Show("Ha ocurrido un error a la hora de editar al cliente!!");  
            }
        }
    }
}
