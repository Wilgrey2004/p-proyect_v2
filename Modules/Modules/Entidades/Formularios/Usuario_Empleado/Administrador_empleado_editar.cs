using MaterialSkin;
using MaterialSkin.Controls;
using p_proyect.Modules.Entidades.BindinLists;
using p_proyect.Modules.Entidades.responses;
using p_proyect.Modules.Enums;
using p_proyect.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_proyect.Modules.Entidades.Formularios.Usuario_Empleado
{
        public partial class Administrador_empleado_editar : MaterialForm

        {
                public Empleado_Admin admin = new Empleado_Admin();
                public Empleado_Admin empleado_admin_seleccionado = new Empleado_Admin();
                public long empleado_admin_seleccionado_id = 0;
                public Administrador_empleado_editar() {
                        InitializeComponent();

                        var materialSkinManager = MaterialSkinManager.Instance;
                        materialSkinManager.AddFormToManage(this);
                        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber600, Primary.Amber700, Primary.Amber800, Accent.LightBlue400, TextShade.BLACK);

                }

                private void Cargar_Combo_Cargos() {
                        Cargo_Combo.DataSource = Enum.GetValues(typeof(Cargos_Empleados_admins));
                }

                private void Cargar_Combo_Estado() {
                        Estado_Combo.DataSource = Enum.GetValues(typeof(Estados_Generales));
                }

                private void Cargar_Info_Del_Empleado() {
                        Nombre_del_Administrador_txt.Text = empleado_admin_seleccionado.Nombre_del_Administrador;
                        Apellido_del_Administrador_txt.Text = empleado_admin_seleccionado.Apellido_del_Administrador;
                        Numero_de_Telefono_txt.Text = empleado_admin_seleccionado.Numero_de_Telefono;
                        Pass_Administrador_txt.Text = empleado_admin_seleccionado.Pass;
                        Pass_confirm_administrador_txt.Text = empleado_admin_seleccionado.Pass_confirm;
                        Cargo_Combo.SelectedItem = empleado_admin_seleccionado.Cargo;
                        Estado_Combo.SelectedItem = empleado_admin_seleccionado.Estado;
                }
                private void Administrador_empleado_editar_Load( object sender, EventArgs e ) {
                        Cargar_Tabla_De_Usuarios_Admins();
                        Cargar_Combo_Cargos();
                        Cargar_Info_Del_Empleado();
                        Cargar_Combo_Estado();
                }

                private void Usuarios_Empleados_DG_CellClick( object sender, DataGridViewCellEventArgs e ) {

                }

                private void materialButton21_Click( object sender, EventArgs e ) {

                }

                private void materialButton24_Click( object sender, EventArgs e ) {

                }
                BindingList<Empleado_Admin_Response> Usuarios_admins_List = new BindingList<Empleado_Admin_Response>();

                private void Cargar_Tabla_De_Usuarios_Admins() {
                        try
                        {

                                Usuarios_admins_List.Clear();
                                Empleado_AdminBindingList empleado_AdminBindingList = new Empleado_AdminBindingList();
                                Usuarios_admins_List = empleado_AdminBindingList.GetList();
                                Usuarios_Empleados_DG.DataSource = null;
                                Usuarios_Empleados_DG.DataSource = Usuarios_admins_List;



                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ocurrio un error en el inicio de secion...\n" + ex);
                        }
                }

                private void Usuarios_Empleados_DG_CellClick_1( object sender, DataGridViewCellEventArgs e ) {
                        try
                        {
                                // Verifica que el click no sea en el encabezado
                                if (e.RowIndex >= 0)
                                {
                                        // Obtiene la fila clickeada
                                        DataGridViewRow fila = Usuarios_Empleados_DG.Rows[e.RowIndex];

                                        // Obtiene el valor de la primera celda (ID)
                                        empleado_admin_seleccionado_id = Convert.ToInt64(fila.Cells[0].Value);

                                        try
                                        {

                                                using (var context = new AppDbContext(OpcionsBuilder_c.getConnection().Options))
                                                {
                                                        empleado_admin_seleccionado = context.Empleado_Admins.FirstOrDefault(x => x.Id == empleado_admin_seleccionado_id);
                                                        if (empleado_admin_seleccionado == null)
                                                        {
                                                                MessageBox.Show("Usaurio no encontrado", "mensaje de busqueda");
                                                                return;
                                                        }
                                                        Cargar_Info_Del_Empleado();
                                                        MessageBox.Show($"Has seleccionado al empleado {empleado_admin_seleccionado}.\nPuedes realizar las acciones de edicion, eliminacion y ver mas informacion.", "Mensaje De Seleeccion.");
                                                        return;
                                                }



                                        } catch (Exception ex)
                                        {
                                                MessageBox.Show("Ocurrio un error en Al seleccionar al Usuario" + ex, "Error detectado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                }
                        } catch (Exception ex)
                        {
                                // Manejo de errores (opcionalmente puedes mostrar el error)
                                MessageBox.Show("Error al obtener el ID: " + ex.Message);
                        }
                }

                private void materialButton23_Click( object sender, EventArgs e ) {

                        var mensaje = MessageBox.Show($"Quieres editar el empleado {empleado_admin_seleccionado}?", "Mensaje de confirmacion para el agregado.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mensaje == DialogResult.No)
                        {
                                return;
                        }

                        if (empleado_admin_seleccionado_id == 0)
                        {
                                MessageBox.Show("Por favor selecciona un usuario de la tabla para editarlo.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                        }

                        if (empleado_admin_seleccionado == null)
                        {
                                MessageBox.Show("Por favor selecciona un usuario de la tabla para editarlo.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                        }



                        empleado_admin_seleccionado.Nombre_del_Administrador = Nombre_del_Administrador_txt.Text;
                        empleado_admin_seleccionado.Apellido_del_Administrador = Apellido_del_Administrador_txt.Text;
                        empleado_admin_seleccionado.Numero_de_Telefono = Numero_de_Telefono_txt.Text;
                        empleado_admin_seleccionado.Pass = Pass_Administrador_txt.Text;
                        empleado_admin_seleccionado.Pass_confirm = Pass_confirm_administrador_txt.Text;
                        empleado_admin_seleccionado.Cargo = (Cargos_Empleados_admins)Cargo_Combo.SelectedItem;
                        empleado_admin_seleccionado.Estado = (Estados_Generales)Estado_Combo.SelectedItem;

                        try
                        {

                                using (var context = new AppDbContext(OpcionsBuilder_c.getConnection().Options))
                                {
                                        context.Empleado_Admins.Update(empleado_admin_seleccionado);
                                        context.SaveChanges();
                                        MessageBox.Show("Empleado editado con exito", "mensaje de edicion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Cargar_Tabla_De_Usuarios_Admins();
                                }



                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ocurrio un error en el inicio de secion...\n" + ex);
                        }
                }
        }
}
