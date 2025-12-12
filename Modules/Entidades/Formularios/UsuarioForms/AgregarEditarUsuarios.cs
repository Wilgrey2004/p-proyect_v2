using MaterialSkin;
using MaterialSkin.Controls;
using p_proyect.Controller.UsuarioController;
using p_proyect.Modules.Entidades.dtos.dtoUsuarios;
using p_proyect.Modules.Enums;
using p_proyect.Utils;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_proyect.Modules.Entidades.Formularios.UsuarioForms
{
    public partial class AgregarEditarUsuarios : MaterialForm
    {
        public Usuarios usuarioActual;
        private UsuarioControllerC usuarioControllerC = new UsuarioControllerC();
        public AgregarEditarUsuarios()
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

        private void AgregarEditarUsuarios_Load(object sender, EventArgs e)
        {
            Cedula_text.MaxLength = 11;

            this.Text = usuarioActual == null ? "Agregar Usuario" : $"Editar al usuario {usuarioActual.Nombre} con el codigo {usuarioActual.Id}";
            ComboHelper.CargarEnumEnCombo<UserRole>(RolUsuario);

            if (usuarioActual != null)
            {
                CargarUsuarioEnControles(usuarioActual);
                return;
            }




        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarUsuarioEnControles(Usuarios usuario)
        {
            if (usuario == null)
                return;

            // ✅ Textos
            Name_txt.Text = usuario.Nombre;
            LastName_txt.Text = usuario.Apellido;
            Cedula_text.Text = usuario.Cedula;
            Correo_txt.Text = usuario.Correo;
            Password_txt.Text = usuario.Contrasena;

            // ✅ Los MaterialTextBox deben tener .UseSystemPasswordChar = false para ver la contraseña,
            // pero como el DTO no debe traer contraseña, no se asigna aquí.

            // ✅ ComboBox (Rol)
            // El combo fue cargado usando un enum, así que seleccionamos por índice
            RolUsuario.SelectedIndex = (int)usuario.Rol;

            // Opcional: mostrar estado si tienes un checkbox o label
            // ActivoCheckBox.Checked = usuario.Activo;
        }

        private UsuarioCreacionDto CrearUsuario()
        {
            return new UsuarioCreacionDto
            {
                Nombre = Name_txt.Text,
                Apellido = LastName_txt.Text,
                Cedula = Cedula_text.Text,
                Correo = Correo_txt.Text,
                Contrasena = Password_txt.Text,
                Rol = (UserRole)RolUsuario.SelectedIndex
            };
        }

        private EditarUsuarioDto.EditUsuarioDto EditarUsuario()
        {
            return new EditarUsuarioDto.EditUsuarioDto
            {
                Id = usuarioActual.Id,
                Nombre = Name_txt.Text,
                Apellido = LastName_txt.Text,
                Cedula = Cedula_text.Text,
                Correo = Correo_txt.Text,
                Contrasena = Password_txt.Text,
                Rol = (int?)RolUsuario.SelectedIndex
                // Puedes agregar Activo si tienes el control correspondiente
                // Activo = ActivoCheckBox.Checked
            };
        }




        private async Task AgregarUsuario()
        {
            var respuesta = MessageBox.Show("Queres agregar a este usuario?", "Pregunta sobre agregado", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }

            await usuarioControllerC.CrearUsuariosAsync(CrearUsuario());

            MessageBox.Show("Usuario agregado con exito");
        }

        private async Task editarUsuario()
        {
            if (usuarioActual == null)
            {
                throw new InvalidOperationException("No se puede editar un usuario No seleccionado.");
            }

            var respuesta = MessageBox.Show($"Estas Seguro de que quieres editar al usuario {usuarioActual.Nombre}?", "Pregunta sobre Edicion", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }

            await usuarioControllerC.EditarUsuariosAsync(EditarUsuario());

            MessageBox.Show("Usuario editado con exito");

        }

        private async void Agregar_usuarios_Click(object sender, EventArgs e)
        {
            if (Cedula_text.Text.Length != 11)
            {
                MessageBox.Show("La cédula debe tener exactamente 11 caracteres.");
                return;
            }

            if (usuarioActual == null)
            {
                await AgregarUsuario();
                Close();
            }

            if (usuarioActual != null)
            {
                await editarUsuario();
                Close();
            }
        }

        private void Cedula_text_TextChanged(object sender, EventArgs e)
        {
            if (Cedula_text.Text.Length > 11)
            {
                MessageBox.Show("La cédula no puede tener más de 11 caracteres.");
                Cedula_text.Text = Cedula_text.Text.Substring(0, 11);
                Cedula_text.SelectionStart = Cedula_text.Text.Length; 
            }
        }
    }
}
