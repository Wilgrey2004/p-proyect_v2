using MaterialSkin;
using MaterialSkin.Controls;
using p_proyect.Controller.ProveedorController;
using p_proyect.Modules.Entidades.dtos.dtoProveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_proyect.Modules.Entidades.Formularios.ProveedorForms
{
    public partial class AgregarEditarProveedor :  MaterialForm

    {
        public Proveedor proveedorActual;
        private ProveedorControllerC proveedorController = new ProveedorControllerC();
        public AgregarEditarProveedor()
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

        private void CargarProveedorEnControles(Proveedor proveedor)
        {
            Nombre_txt.Text = proveedor.Nombre;
            Contacto_txt.Text = proveedor.Contacto;
        }

        private void AgregarEditarProveedor_Load(object sender, EventArgs e)
        {
            Text = proveedorActual == null ? "Agregar Proveedor" : $"Editar al Proveedor {proveedorActual.Nombre}";

            if(proveedorActual != null)
            {
                CargarProveedorEnControles(proveedorActual);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private async void Agregar_usuarios_Click(object sender, EventArgs e)
        {
            if(proveedorActual != null)
            {
                ProveedorMostrarDto proveedorMostrarDto = new ProveedorMostrarDto()
                {
                    Nombre = Nombre_txt.Text,
                    Contacto = Contacto_txt.Text,
                };

                await proveedorController.CrearProovedor(proveedorMostrarDto);
                MessageBox.Show("Proveedor creado con exito");
            }
            else
            {
                ProveedorMostrarDto proveedorEditarDto = new ProveedorMostrarDto()
                {
                    Id = proveedorActual.Id,
                    Nombre = Nombre_txt.Text,
                    Contacto = Contacto_txt.Text,
                };
                await proveedorController.ModificarProovedor(proveedorEditarDto);
                MessageBox.Show("Proveedor editado con exito");
            }

                Close();
        }
    }
}
