using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using p_proyect.Modules;
using p_proyect.Modules.Entidades;
using System;
using System.Linq;
using System.Windows.Forms;

namespace p_proyect
{
    public partial class InicioDeSecion : MaterialForm
    {
        public InicioDeSecion()
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

        private void InicioDeSecion_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Usuarios usuarioEnSecion = new Usuarios();

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                usuarioEnSecion = context.Usuarios.FirstOrDefault(x => x.Nombre == NombreDelUsuario.Text && x.Contrasena == ClaveDelUsuario.Text);
                if (usuarioEnSecion == null)
                {
                    MessageBox.Show("Nombre o Contraseña invalidos\nEn dado caso de no tener un usuario hable con el administrador para que se le cree uno.");
                    return;
                }


                try
                {
                    Main main = new Main();

                    main.SecionActual = usuarioEnSecion;

                    Hide();

                    main.ShowDialog();

                    Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al iniciar sesion: " + ex.Message);
                }

                
            }
        }
    }
}
