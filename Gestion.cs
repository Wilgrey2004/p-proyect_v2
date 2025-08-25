using Bunifu.UI.WinForms;
using MaterialSkin;
using MaterialSkin.Controls;
using p_proyect.Modules;
using p_proyect.Modules.Entidades;
using p_proyect.Modules.Entidades.BindinLists;
//using p_proyect.Modules.Entidades.Formularios.Cursos;
using p_proyect.Modules.Entidades.Formularios.Estudiantes;
using p_proyect.Modules.Entidades.Formularios.F_Cursos;
using p_proyect.Modules.Entidades.Formularios.Profesores;
using p_proyect.Modules.Entidades.Formularios.Usuario_Empleado;
using p_proyect.Modules.Entidades.request;


//using p_proyect.Modules.Entidades.Formularios
using p_proyect.Modules.Entidades.responses;
using p_proyect.Modules.Enums;
using p_proyect.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_proyect
{
        public partial class Gestion : MaterialForm
        {
                public Empleado_Admin admin = new Empleado_Admin();
                public Gestion() {
                        InitializeComponent();

                        var materialSkinManager = MaterialSkinManager.Instance;
                        materialSkinManager.AddFormToManage(this);
                        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber600, Primary.Amber700, Primary.Amber800, Accent.LightBlue400, TextShade.BLACK);

                }

                private void Cargar_Tablas() {
                        Cargar_Tabla_Profesores();
                        Cargar_Tabla_De_Estudiantes();
                        CargarTabla_De_Cursos();

                }

                BindingList<Estudiantes_Response> estudiantes_Responses = new BindingList<Estudiantes_Response>();
                private void Cargar_Tabla_De_Estudiantes() {
                        Estudiantes_BindingList estudiantes_BindingList = new Estudiantes_BindingList();
                        estudiantes_Responses = estudiantes_BindingList.GetList();
                        Lista_De_Estudiantes.Clear();
                        Lista_De_Estudiantes = estudiantes_Responses;
                        Estudiantes_dataview.DataSource = Lista_De_Estudiantes;
                }



                BindingList<Estudiantes_Response> Lista_De_Estudiantes = new BindingList<Estudiantes_Response>();
                BindingList<Cursos_Response> Cursos_Lista = new BindingList<Cursos_Response>();

                private void CargarTabla_De_Cursos() {
                        try
                        {
                                Cursos_BindingList cursos_BindingList = new Cursos_BindingList();

                                Cursos_Lista.Clear();
                                Cursos_Lista = cursos_BindingList.GetList();
                                Listado_De_Cursos_dg.DataSource = Cursos_Lista;




                        } catch (Exception ex)
                        {
                                MessageBox.Show("ha ocurrido un erro cargando los cursos\n" + ex, "Error detectado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }

                private void Cargar_Combo_Boxes() {
                        Cargar_Combo_Boxes_Dias_De_La_Semana();
                        Cargar_Combo_Box_Profesores();
                        Cargar_Combo_Box_Genero();
                        Cargar_Combo_Box_Nivel_Educacional();
                        Cargar_Combo_Box_Si_No();
                }


                private void Cargar_Combo_Box_Si_No() {
                        Estudia_En_La_Actualidad_com.DataSource = Enum.GetValues(typeof(Si_No_Enums));
                        Estudia_En_La_Actualidad_com.SelectedIndex = 0; // Selecciona el primer elemento por defecto
                }

                private void Cargar_Combo_Box_Nivel_Educacional() {
                        Nivel_Educacional_Del_Estudiante_com.DataSource = Enum.GetValues(typeof(Nivel_Educacional));
                        Nivel_Educacional_Del_Estudiante_com.SelectedIndex = 0; // Selecciona el primer elemento por defecto
                }

                private void Cargar_Combo_Box_Genero() {
                        Genero_Del_Estudiante_com.DataSource = Enum.GetValues(typeof(Sexo));
                }

                private void Cargar_Combo_Box_Profesores() {
                        try
                        {
                                using (var context = new AppDbContext(OpcionsBuilder_c.getConnection().Options))
                                {
                                        var ListaDeProfesores = context.Profesors.Select(p => new {
                                                p.Id,
                                                NombreCompleto = p.Nombre + " " + p.Apellido
                                        }).ToList();
                                        Profesor_Que_Imparte_El_Curso_com.DataSource = ListaDeProfesores;
                                        Profesor_Que_Imparte_El_Curso_com.DisplayMember = "NombreCompleto";
                                        Profesor_Que_Imparte_El_Curso_com.ValueMember = "Id";
                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ocurrio un error en la carga de profesores al combobox\n" + ex);
                        }
                }
                private void Cargar_Combo_Boxes_Dias_De_La_Semana() {
                        Dia_En_Que_Se_Imparte_com.DataSource = Enum.GetValues(typeof(Dias_De_La_Semana));
                }

                private BindingList<Profesores_Response> Lista_De_Profesores_Blindada = new BindingList<Profesores_Response>();

                private void Cargar_Tabla_Profesores() {
                        try
                        {
                                Profesor_BindingList profesores = new Profesor_BindingList();
                                Lista_De_Profesores_Blindada = profesores.GetList();
                                Profesores_dg.DataSource = Lista_De_Profesores_Blindada;
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ocurrio un error en la carga de profesores...\n" + ex, "Error detectado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                }
                private void Gestion_Load( object sender, EventArgs e ) {
                        if (admin.Cargo != Cargos_Empleados_admins.Administrador)
                        {
                                materialTabControl1.TabPages.Remove(tabPage6);
                        }
                        Cargar_Combo_Boxes();
                        Colocar_Formato_A_Los_Data_Pikers();
                        Cargar_Labels();
                        Cargar_Tabala_Adeudos();

                }
                BindingList<Adeudo_Response> adeudo_Responses = new BindingList<Adeudo_Response>();
                private void Cargar_Tabala_Adeudos() {
                        Adeudo_Estudiantes_BindingList adeudo_Estudiantes_BindingList = new Adeudo_Estudiantes_BindingList();

                        adeudo_Responses.Clear();
                        adeudo_Responses = adeudo_Estudiantes_BindingList.GetList();

                        Adeudo_data_Grid.DataSource = null;

                        Adeudo_data_Grid.DataSource = adeudo_Responses;
                }

                private async void Cargar_Labels() {
                        try
                        {
                                int cantidad_De_Estudiantes = 0;
                                int cursos_Disponibles = 0;
                                int cantidad_de_Profesores = 0;

                                using (var context = new AppDbContext(OpcionsBuilder_c.getConnection().Options))
                                {
                                        cantidad_De_Estudiantes = context.Estudiantes.Count();
                                        cursos_Disponibles = context.Cursos.Count();
                                        cantidad_de_Profesores = context.Profesors.Count();
                                }

                                await Task.WhenAll(
                                       Contador_Label(Cantidad_De_Estudiantes_label, cantidad_De_Estudiantes),
                                       Contador_Label(Cursos_Disponibles_label, cursos_Disponibles),
                                       Contador_Label(Cantidad_De_Profesores_label, cantidad_de_Profesores)
                               );



                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ha ocurrido un error al contar a los estudiantes y cursos...\n" + ex);
                        }
                }

                private async Task Contador_Label( BunifuLabel label, int hasta ) {
                        label.Invoke((MethodInvoker)(() => {
                                label.AutoSize = false;
                                label.Size = new Size(100, 40);
                                label.Invoke((MethodInvoker)(() => label.TextAlign = (BunifuLabel.TextAlignments)ContentAlignment.MiddleCenter));
                                label.Font = new Font("Segoe UI", 28, FontStyle.Bold); // opcional
                        }));
                        for (int i = 1; i <= hasta; i++)
                        {

                                label.Invoke((MethodInvoker)(() => label.Text = i.ToString()));
                                //label.Size = new System.Drawing.Size(22, 22);
                                await Task.Delay(500);
                        }
                }


                private void Colocar_Formato_A_Los_Data_Pikers() {
                        Hora_De_Inicio_dp.Format = DateTimePickerFormat.Time;
                        Hora_De_Inicio_dp.ShowUpDown = true;
                        //Hora_De_Inicio_dp.Value = DateTime.Now;

                        Hora_De_Finalizacion.Format = DateTimePickerFormat.Time;
                        Hora_De_Finalizacion.ShowUpDown = true;

                }

                private void agregarToolStripMenuItem_Click( object sender, EventArgs e ) {

                }

                private void tabPage1_Click( object sender, EventArgs e ) {

                }

                private void Nombre_Usuario_txt_TextChanged( object sender, EventArgs e ) {

                }

                private void bunifuTextBox2_TextChanged( object sender, EventArgs e ) {

                }

                private void bunifuPanel1_Click( object sender, EventArgs e ) {

                }

                private void bunifuLabel2_Click( object sender, EventArgs e ) {

                }
                int Id_Profesor_Seleccionado = 0;
                Profesor profesor_Seleccionado;
                private void Profesores_dg_CellClick( object sender, DataGridViewCellEventArgs e ) {
                        try
                        {
                                // Verifica que el click no sea en el encabezado
                                if (e.RowIndex >= 0)
                                {
                                        // Obtiene la fila clickeada
                                        DataGridViewRow fila = Profesores_dg.Rows[e.RowIndex];

                                        // Obtiene el valor de la primera celda (ID)
                                        Id_Profesor_Seleccionado = Convert.ToInt32(fila.Cells[0].Value);

                                        // Muestra el ID (corrigiendo el nombre de la variable)
                                        // MessageBox.Show($" has seleccionado el profesor con el Codigo: {Id_Profesor_Seleccionado}");

                                        try
                                        {

                                                using (var context = new AppDbContext(OpcionsBuilder_c.getConnection().Options))
                                                {
                                                        profesor_Seleccionado = context.Profesors.FirstOrDefault(x => x.Id == Id_Profesor_Seleccionado);
                                                        if (profesor_Seleccionado == null)
                                                        {
                                                                MessageBox.Show("Profesor no encontrado", "mensaje de busqueda");
                                                                return;
                                                        }

                                                        MessageBox.Show($"Has seleccionado al profesor {profesor_Seleccionado}.\nPuedes realizar las acciones de edicion, eliminacion y ver mas informacion.", "Mensaje De Seleeccion.");
                                                        return;
                                                }



                                        } catch (Exception ex)
                                        {
                                                MessageBox.Show("Ocurrio un error en Al seleccionar al profesor" + ex, "Error detectado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                }
                        } catch (Exception ex)
                        {
                                // Manejo de errores (opcionalmente puedes mostrar el error)
                                MessageBox.Show("Error al obtener el ID: " + ex.Message);
                        }
                }

                private void materialButton1_Click( object sender, EventArgs e ) {

                        if (Nombre_Profesor_txt.Text == "" || Apellido_Profesor_txt.Text == "")
                        {
                                MessageBox.Show("Nombre o apellido del profesor estan vacios...", "Mensaje de navegacion");
                                return;
                        }

                        var mensaje = MessageBox.Show($"Quiere Agregar al profesor {Nombre_Profesor_txt.Text}?", "Mensaje de confirmacion para el agregado.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mensaje == DialogResult.No)
                        {
                                return;
                        }


                        try
                        {
                                Profesor profesor = new Profesor();
                                profesor.Nombre = Nombre_Profesor_txt.Text.Trim();
                                profesor.Apellido = Apellido_Profesor_txt.Text.Trim();
                                profesor.Numero_De_Telefono = Numero_Del_Profesor_txt.Text.Trim();

                                using (var context = new AppDbContext(OpcionsBuilder_c.getConnection().Options))
                                {
                                        context.Profesors.Add(profesor);
                                        context.SaveChanges();
                                        MessageBox.Show($"El profesor {profesor} ha sido agregado correctamente.", "Profesor Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Cargar_Tablas();
                                }



                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ocurrio un error en Al agregar al profesor" + ex, "Error detectado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }

                private void Profesores_dg_CellContentClick( object sender, DataGridViewCellEventArgs e ) {

                }

                private void materialButton2_Click( object sender, EventArgs e ) {

                        if (profesor_Seleccionado == null)
                        {
                                MessageBox.Show("No hay profesor seleccionado", "mensaje de busqueda");
                                return;
                        }


                        var mensaje = MessageBox.Show($"Quiere Editar al profesor {Nombre_Profesor_txt.Text}?", "Mensaje de confirmacion para el agregado.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mensaje == DialogResult.No)
                        {
                                return;
                        }

                        Profesor_Editar profesor_Editar = new Profesor_Editar();
                        profesor_Editar.profesor = profesor_Seleccionado;
                        profesor_Editar.ShowDialog();
                        CargarTabla_De_Cursos();
                }

                private void materialButton3_Click( object sender, EventArgs e ) {

                        if (profesor_Seleccionado == null)
                        {
                                MessageBox.Show("No hay profesor seleccionado", "mensaje de busqueda");
                                return;
                        }

                        var mensaje = MessageBox.Show($"Quiere Eliminar al profesor {Nombre_Profesor_txt.Text}?", "Mensaje de confirmacion para el agregado.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mensaje == DialogResult.No)
                        {
                                return;
                        }

                        try
                        {

                                using (var context = new AppDbContext(OpcionsBuilder_c.getConnection().Options))
                                {
                                        profesor_Seleccionado.Estados_Generales = Modules.Enums.Estados_Generales.Inactivo;
                                        context.Profesors.Update(profesor_Seleccionado);
                                        context.SaveChanges();
                                        Cargar_Tablas();
                                        MessageBox.Show($"El profesor {profesor_Seleccionado.Nombre} {profesor_Seleccionado.Apellido} ha sido eliminado correctamente.", "Profesor Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        profesor_Seleccionado = null; // Limpiar la variable para evitar errores futuros
                                        return;
                                }
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ocurrio un error en la eliminacion del profesor\n" + ex);
                        }
                }

                private void bunifuLabel14_Click( object sender, EventArgs e ) {

                }

                private Cursos Crear_Curso() {

                        Cursos nuevo_Curso = new Cursos() {

                        };
                        nuevo_Curso.Nombre = Nombre_Del_Curso_txt.Text.Trim();
                        nuevo_Curso.Descripcion = Descripcion_Del_Curso_txt.Text.Trim();
                        nuevo_Curso.Dia_Curso = (Dias_De_La_Semana)Dia_En_Que_Se_Imparte_com.SelectedItem;
                        nuevo_Curso.Hora_De_Inicio = Hora_De_Inicio_dp.Value.TimeOfDay;
                        nuevo_Curso.Hora_De_Finalizacion = Hora_De_Finalizacion.Value.TimeOfDay;
                        nuevo_Curso.Profesor_Id = (long)Profesor_Que_Imparte_El_Curso_com.SelectedValue;
                        nuevo_Curso.Costo_Del_Curso = Convert.ToDecimal(Costo_Total_Del_Curso_txt.Text.Trim());
                        nuevo_Curso.Inscripcion = Convert.ToDecimal(Costo_De_La_Inscripcion_Del_Curso_txt.Text.Trim());

                        return nuevo_Curso;
                }

                private void materialButton10_Click( object sender, EventArgs e ) {
                        if (Nombre_Del_Curso_txt.Text == "" || Descripcion_Del_Curso_txt.Text == "")
                        {
                                MessageBox.Show("Nombre o descripcion del curso estan vacios...", "Mensaje de navegacion");
                                return;
                        }

                        var mensaje = MessageBox.Show($"Quiere Agregar El Curso {Nombre_Del_Curso_txt.Text}", "Mensaje de confirmacion para el agregado.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mensaje == DialogResult.No)
                        {
                                return;
                        }

                        try
                        {

                                using (var context = new AppDbContext(OpcionsBuilder_c.getConnection().Options))
                                {
                                        context.Cursos.Add(Crear_Curso());
                                        context.SaveChanges();
                                        MessageBox.Show($"El curso {Nombre_Del_Curso_txt.Text} ha sido agregado correctamente.", "Curso Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        CargarTabla_De_Cursos();
                                        return;
                                }



                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ha ocurrido un error al agregar el curso\n" + ex);
                        }
                }
                long Id_del_Curso_Seleccionado = 0;
                Cursos Curso_Seleccionado;
                private void Listado_De_Cursos_dg_CellClick( object sender, DataGridViewCellEventArgs e ) {
                        try
                        {
                                // Verifica que el click no sea en el encabezado
                                if (e.RowIndex >= 0)
                                {
                                        // Obtiene la fila clickeada
                                        DataGridViewRow fila = Listado_De_Cursos_dg.Rows[e.RowIndex];

                                        // Obtiene el valor de la primera celda (ID)
                                        Id_del_Curso_Seleccionado = Convert.ToInt64(fila.Cells[0].Value);

                                        // Muestra el ID (corrigiendo el nombre de la variable)
                                        // MessageBox.Show($" has seleccionado el profesor con el Codigo: {Id_Profesor_Seleccionado}");

                                        try
                                        {

                                                using (var context = new AppDbContext(OpcionsBuilder_c.getConnection().Options))
                                                {
                                                        Curso_Seleccionado = context.Cursos.FirstOrDefault(x => x.Id == Id_del_Curso_Seleccionado);
                                                        if (Curso_Seleccionado == null)
                                                        {
                                                                MessageBox.Show("Curso no encontrado", "mensaje de busqueda");
                                                                return;
                                                        }

                                                        MessageBox.Show($"Has seleccionado el curso {Curso_Seleccionado}.\nPuedes realizar las acciones de edicion, eliminacion y ver mas informacion.", "Mensaje De Seleeccion.");
                                                        return;
                                                }



                                        } catch (Exception ex)
                                        {
                                                MessageBox.Show("Ocurrio un error en Al seleccionar al Curso" + ex, "Error detectado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                }
                        } catch (Exception ex)
                        {
                                // Manejo de errores (opcionalmente puedes mostrar el error)
                                MessageBox.Show("Error al obtener el ID: " + ex.Message);
                        }
                }

                private void materialButton8_Click( object sender, EventArgs e ) {

                        if (Curso_Seleccionado == null)
                        {
                                MessageBox.Show("No hay curso seleccionado", "mensaje de busqueda");
                                return;
                        }

                        var mensaje = MessageBox.Show($"Quiere Eliminar el curso {Nombre_Del_Curso_txt.Text}?", "Mensaje de confirmacion para el agregado.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mensaje == DialogResult.No)
                        {
                                return;
                        }
                        try
                        {

                                using (var context = new AppDbContext(OpcionsBuilder_c.getConnection().Options))
                                {
                                        Curso_Seleccionado.Estado_Actual_Del_Curso = Modules.Enums.Estados_Generales.Inactivo;
                                        context.Cursos.Update(Curso_Seleccionado);
                                        context.SaveChanges();
                                        CargarTabla_De_Cursos();
                                        MessageBox.Show($"El curso {Curso_Seleccionado.Nombre} ha sido eliminado correctamente.", "Curso Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                }



                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ocurrio un error al tratar de eliminar el curso\n" + ex);
                        }

                }

                private void bunifuLabel10_Click( object sender, EventArgs e ) {

                }

                private void bunifuLabel19_Click( object sender, EventArgs e ) {

                }

                private Estudiante Crear_Estudiante() {
                        Estudiante Nuevo_Estudiante = new Estudiante();
                        Nuevo_Estudiante.Nombre = Nombre_Del_Estudiante_txt.Text.Trim();
                        Nuevo_Estudiante.Apellido = Apellido_Del_Estudiante_txt.Text.Trim();
                        Nuevo_Estudiante.Edad = Convert.ToInt32(Edad_Del_Estudiante_txt.Text.Trim());
                        Nuevo_Estudiante.Cedula = Cedula_Del_Estudiante_txt.Text.Trim();
                        Nuevo_Estudiante.Sexo = (Sexo)Genero_Del_Estudiante_com.SelectedItem;
                        Nuevo_Estudiante.Apodo = Apodo_Del_Estudiante_txt.Text.Trim();
                        Nuevo_Estudiante.Direccion = Direccion_Del_Estudiante_txt.Text.Trim();
                        Nuevo_Estudiante.Municipio = Municipio_Del_Estudiante_txt.Text.Trim();
                        Nuevo_Estudiante.Sector = Sector_Del_Estudiante_txt.Text.Trim();
                        Nuevo_Estudiante.Nombre_del_tutor = Nombre_Del_Tutor_Del_Estudiante_txt.Text.Trim();
                        Nuevo_Estudiante.Telefono_del_tutor = Numero_Del_Tutor_Del_Estudiante_txt.Text.Trim();
                        Nuevo_Estudiante.Cantidad_De_Cursos_A_Los_Que_Esta_Inscrito = 0;
                        Nuevo_Estudiante.Id_Empleado = admin.Id;
                        return Nuevo_Estudiante;
                }

                private void materialButton15_Click( object sender, EventArgs e ) {

                        if (Nombre_Del_Estudiante_txt.Text == "" || Apellido_Del_Estudiante_txt.Text == "")
                        {
                                MessageBox.Show("Nombre o apellido del estudiante estan vacios...", "Mensaje de navegacion");
                                return;
                        }

                        var mensaje = MessageBox.Show($"Quiere Agregar al Estudiante {Nombre_Del_Estudiante_txt.Text}?", "Mensaje de confirmacion para el agregado.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mensaje == DialogResult.No)
                        {
                                return;
                        }

                        try
                        {

                                using (var context = new AppDbContext(OpcionsBuilder_c.getConnection().Options))
                                {
                                        Estudiante Nuevo_Estudiante = Crear_Estudiante();
                                        context.Estudiantes.Add(Nuevo_Estudiante);
                                        context.SaveChanges();
                                        Cargar_Tabla_De_Estudiantes();
                                        MessageBox.Show($"El estudiante {Nuevo_Estudiante.Nombre} {Nuevo_Estudiante.Apellido} ha sido agregado correctamente.", "Estudiante Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                }



                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ha ocurrido un erro al crear al Estudiante\n" + ex);
                        }
                }

                private void materialButton17_Click( object sender, EventArgs e ) {
                        Inscribir_al_Estudiante_A_Un_Curso inscribir_al_Estudiante_A_Un_Curso = new Inscribir_al_Estudiante_A_Un_Curso();
                        if (Estudiante_Seleccionado == null)
                        {
                                MessageBox.Show("No hay estudiante seleccionado", "mensaje de busqueda");
                                return;
                        }
                        inscribir_al_Estudiante_A_Un_Curso.Estudiante = Estudiante_Seleccionado; // Asegúrate de que Estudiante_Seleccionado esté definido y sea válido
                        inscribir_al_Estudiante_A_Un_Curso.ShowDialog();
                        Cargar_Tabla_De_Estudiantes();
                        CargarTabla_De_Cursos();
                }


                long Id_del_Estudiante_Seleccionado = 0;
                Estudiante Estudiante_Seleccionado;
                private void Estudiantes_dataview_CellContentClick( object sender, DataGridViewCellEventArgs e ) {
                        //MessageBox.Show("Hola :)");
                }

                private void Estudiantes_dataview_CellClick( object sender, DataGridViewCellEventArgs e ) {
                        try
                        {
                                // Verifica que el click no sea en el encabezado
                                if (e.RowIndex >= 0)
                                {
                                        // Obtiene la fila clickeada
                                        DataGridViewRow fila = Estudiantes_dataview.Rows[e.RowIndex];

                                        // Obtiene el valor de la primera celda (ID)
                                        Id_del_Estudiante_Seleccionado = Convert.ToInt64(fila.Cells[0].Value);

                                        try
                                        {

                                                using (var context = new AppDbContext(OpcionsBuilder_c.getConnection().Options))
                                                {
                                                        Estudiante_Seleccionado = context.Estudiantes.FirstOrDefault(x => x.Id == Id_del_Estudiante_Seleccionado);
                                                        if (Estudiante_Seleccionado == null)
                                                        {
                                                                MessageBox.Show("Curso no encontrado", "mensaje de busqueda");
                                                                return;
                                                        }

                                                        MessageBox.Show($"Has seleccionado al profesor {Estudiante_Seleccionado}.\nPuedes realizar las acciones de edicion, eliminacion y ver mas informacion.", "Mensaje De Seleeccion.");
                                                        return;
                                                }



                                        } catch (Exception ex)
                                        {
                                                MessageBox.Show("Ocurrio un error en Al seleccionar al Curso" + ex, "Error detectado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                }
                        } catch (Exception ex)
                        {
                                // Manejo de errores (opcionalmente puedes mostrar el error)
                                MessageBox.Show("Error al obtener el ID: " + ex.Message);
                        }
                }

                private void materialButton18_Click( object sender, EventArgs e ) {

                        if (profesor_Seleccionado == null)
                        {
                                MessageBox.Show("No hay profesor seleccionado", "Mensaje de navegacion");
                                return;
                        }

                        var mensaje = MessageBox.Show($"Quiere Asignar al profesor {Nombre_Profesor_txt.Text} a un curso ?", "Mensaje de confirmacion para el agregado.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mensaje == DialogResult.No)
                        {
                                return;
                        }


                        Asignar_Profesor_A_Un_Curso asignar_Profesor_A_Un_Curso = new Asignar_Profesor_A_Un_Curso();
                        asignar_Profesor_A_Un_Curso.Profesor_Seleccionado = profesor_Seleccionado;
                        asignar_Profesor_A_Un_Curso.ShowDialog();
                        Cargar_Tabla_Profesores();
                        CargarTabla_De_Cursos();
                }

                private async void materialButton13_Click( object sender, EventArgs e ) {
                        if (Estudiante_Seleccionado == null)
                        {
                                MessageBox.Show("No hay estudiante seleccionado", "mensaje de busqueda");
                                return;
                        }

                        var mensaje = MessageBox.Show($"Estas seguro de que quieres eliminar al estudiante {Estudiante_Seleccionado.Nombre}", "Mensaje de confirmacion para el agregado.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mensaje == DialogResult.No)
                        {
                                return;
                        }

                        try
                        {

                                using (var context = new AppDbContext(OpcionsBuilder_c.getConnection().Options))
                                {
                                        Estudiante_Seleccionado.Estado = Estados_Generales.Inactivo;
                                        context.Estudiantes.Update(Estudiante_Seleccionado);
                                        await context.SaveChangesAsync();
                                        Cargar_Tabla_De_Estudiantes();
                                        MessageBox.Show($"El estudiante {Estudiante_Seleccionado.Nombre} {Estudiante_Seleccionado.Apellido} ha sido eliminado correctamente.", "Estudiante Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Estudiante_Seleccionado = null; // Limpiar la variable para evitar errores futuros
                                }



                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ocurrio un error al eliminar al estudiante...\n" + ex);
                        }
                }

                private void materialTabControl1_SelectedIndexChanged( object sender, EventArgs e ) {
                        switch (materialTabControl1.SelectedIndex)
                        {
                                case 0:
                                        Cargar_Labels();
                                        break;
                                default:
                                        break;
                                case 1:
                                        Cargar_Tabla_Profesores();
                                        break;
                                case 2:
                                        CargarTabla_De_Cursos();
                                        break;
                                case 3:
                                        Cargar_Tabla_De_Estudiantes();
                                        break;
                                case 4:
                                        Cargar_Tabala_Adeudos();
                                        break;

                                case 5:
                                        Cargar_Tabla_De_Usuarios_Admins();
                                        break;

                        }
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

                private void materialButton9_Click( object sender, EventArgs e ) {

                        if (Curso_Seleccionado == null)
                        {
                                MessageBox.Show("No hay curso seleccionado", "mensaje de busqueda");
                                return;
                        }

                        var mensaje = MessageBox.Show($"Quieres editar el curso {Nombre_Del_Curso_txt.Text}?", "Mensaje de confirmacion para el agregado.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mensaje == DialogResult.No)
                        {
                                return;
                        }

                        F_Cursos_Editar f_Cursos_Editar = new F_Cursos_Editar();
                        f_Cursos_Editar.Curso_Seleccionado = Curso_Seleccionado;
                        f_Cursos_Editar.ShowDialog();
                        CargarTabla_De_Cursos();
                }

                private void materialButton14_Click( object sender, EventArgs e ) {

                        if (Estudiante_Seleccionado == null)
                        {
                                MessageBox.Show("No hay estudiante seleccionado", "mensaje de busqueda");
                                return;
                        }

                        var mensaje = MessageBox.Show($"Quires editar al estudiante ${Estudiante_Seleccionado.Nombre}", "Mensaje de confirmacion para el agregado.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mensaje == DialogResult.No)
                        {
                                return;
                        }

                        Edicion_Estudiante_F edicion_Estudiante_F = new Edicion_Estudiante_F();
                        edicion_Estudiante_F.Estudiante_A_Editar = Estudiante_Seleccionado;
                        edicion_Estudiante_F.ShowDialog();
                        Cargar_Tabla_De_Estudiantes();
                }

                private void materialTabControl1_Selected( object sender, TabControlEventArgs e ) {

                }

                private void materialButton4_Click( object sender, EventArgs e ) {
                        if (profesor_Seleccionado == null)
                        {
                                MessageBox.Show("No hay profesor seleccionado", "mensaje de busqueda");
                                return;
                        }

                        Mas_Informacion_Profesor mas_Informacion_Profesor = new Mas_Informacion_Profesor();
                        mas_Informacion_Profesor.Profesor_Seleccionado = profesor_Seleccionado;
                        mas_Informacion_Profesor.ShowDialog();
                        Cargar_Tabla_Profesores();
                }

                private void materialButton7_Click( object sender, EventArgs e ) {
                        if (Curso_Seleccionado == null)
                        {
                                MessageBox.Show("No hay Curso seleccionado", "mensaje de busqueda");
                                return;
                        }

                        F_Cursos_Mas_Informacion mas_Informacion_Curso = new F_Cursos_Mas_Informacion();
                        mas_Informacion_Curso.Curso_Seleccionado = Curso_Seleccionado;
                        mas_Informacion_Curso.ShowDialog();
                        CargarTabla_De_Cursos();
                }

                private void materialButton12_Click( object sender, EventArgs e ) {
                        if (Estudiante_Seleccionado == null)
                        {
                                MessageBox.Show("No hay estudiante seleccionado", "mensaje de busqueda");
                                return;
                        }

                }

                private void Limpiar_Cajas_En_Adeudos() {
                        Nombre_Del_Curso_Adeudo_txt.Text = "";
                        Descripcion_Del_Curso_Adeudo_txt.Text = "";

                        Nombre_estudiante_Adeudo_txt.Text = "";
                        Apellido_Estudiante_Adeudo_txt.Text = "";
                        Cedula_Estudiante_Adeudo_txt.Text = "";
                        Edad_Estudiante_Adeudo_txt.Text = "";

                        Adeudo_Total_txt.Text = "";
                        Restante_A_Pagar_Adeudo_txt.Text = "";
                        Total_A_Pagar_Adeudo_txt.Text = "";
                }

                private void Cargar_Cajas_Con_Informacon_En_Adeudos( Adeudo_Response Adeudo_Response_Seleccionado ) {

                        Nombre_Del_Curso_Adeudo_txt.Text = Adeudo_Response_Seleccionado.Nombre_Curso;
                        Descripcion_Del_Curso_Adeudo_txt.Text = Adeudo_Response_Seleccionado.Descripcion_Del_Curso;

                        Nombre_estudiante_Adeudo_txt.Text = Adeudo_Response_Seleccionado.Nombre_Estudiante;
                        Apellido_Estudiante_Adeudo_txt.Text = Adeudo_Response_Seleccionado.Apellido_Estudiante;
                        Cedula_Estudiante_Adeudo_txt.Text = Adeudo_Response_Seleccionado.Cedula_Estudiante;
                        Edad_Estudiante_Adeudo_txt.Text = Adeudo_Response_Seleccionado.Edad_Estudiante.ToString();

                        Adeudo_Total_txt.Text = Adeudo_Response_Seleccionado.Adeudo.ToString();
                        Restante_A_Pagar_Adeudo_txt.Text = Adeudo_Response_Seleccionado.Restante_A_Pagar.ToString();
                        Total_A_Pagar_Adeudo_txt.Text = Adeudo_Response_Seleccionado.Total_Pagado.ToString();
                }
                long Id_Adeudo_Seleccionado = 0;

                Adeudo_Response Adeudo_Response_Seleccionado;
                private void Adeudo_data_Grid_CellClick( object sender, DataGridViewCellEventArgs e ) {
                        try
                        {
                                // Verifica que el click no sea en el encabezado
                                if (e.RowIndex >= 0)
                                {
                                        // Obtiene la fila clickeada
                                        DataGridViewRow fila = Adeudo_data_Grid.Rows[e.RowIndex];

                                        // Obtiene el valor de la primera celda (ID)
                                        Id_Adeudo_Seleccionado = Convert.ToInt64(fila.Cells[0].Value);

                                        try
                                        {



                                                Adeudo_Response_Seleccionado = adeudo_Responses.FirstOrDefault(x => x.Id == Id_Adeudo_Seleccionado);

                                                if (Adeudo_Response_Seleccionado == null)
                                                {
                                                        MessageBox.Show("Curso no encontrado", "mensaje de busqueda");
                                                        return;
                                                }
                                                Limpiar_Cajas_En_Adeudos();

                                                Cargar_Cajas_Con_Informacon_En_Adeudos(Adeudo_Response_Seleccionado);



                                                MessageBox.Show($"Has seleccionado el adeudo del estduiante {Adeudo_Response_Seleccionado.Nombre_Estudiante} en el curso {Adeudo_Response_Seleccionado.Nombre_Curso}.\nPuedes realizar las acciones de Agragar Curota", "Mensaje De Seleeccion.");
                                                return;




                                        } catch (Exception ex)
                                        {
                                                MessageBox.Show("Ocurrio un error en Al seleccionar al Curso" + ex, "Error detectado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                }
                        } catch (Exception ex)
                        {
                                // Manejo de errores (opcionalmente puedes mostrar el error)
                                MessageBox.Show("Error al obtener el ID: " + ex.Message);
                        }
                }

                private void materialButton22_Click( object sender, EventArgs e ) {
                        if (Adeudo_Response_Seleccionado == null)
                        {
                                MessageBox.Show("No hay adeudo seleccionado", "mensaje de busqueda");
                                return;
                        }

                        var mensaje = MessageBox.Show($"Quieres agreagar El pago de {Cutota_Adeudo_txt.Text} a la deuda del estudiante {Nombre_estudiante_Adeudo_txt.Text} en el curso {Nombre_Del_Curso_Adeudo_txt.Text} ?", "Mensaje de confirmacion para el agregado.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mensaje == DialogResult.No)
                        {
                                return;
                        }

                        try
                        {

                                using (var context = new AppDbContext(OpcionsBuilder_c.getConnection().Options))
                                {
                                        ImpresionRecibo imprimirRecibo = new ImpresionRecibo();
                                        Adeudo_Curso adeudo_Curso = new Adeudo_Curso();

                                        adeudo_Curso = context.Adeudos_Cursos.FirstOrDefault(x => x.Id == Id_Adeudo_Seleccionado);

                                        adeudo_Curso.Total_Pagado += Convert.ToDecimal(Cutota_Adeudo_txt.Text);
                                        adeudo_Curso.Restante_A_Pagar -= Convert.ToDecimal(Cutota_Adeudo_txt.Text);
                                        adeudo_Curso.Fecha_Del_Ultimo_Pago = DateTime.Now;
                                        adeudo_Curso.Fecha_Del_Siguiente_Pago = CambiarADia25MesSiguiente(adeudo_Curso.Fecha_Del_Ultimo_Pago);

                                        context.SaveChanges();

                                        Adeudo_Response_Seleccionado.Total_Pagado = adeudo_Curso.Total_Pagado;
                                        Adeudo_Response_Seleccionado.Restante_A_Pagar = adeudo_Curso.Restante_A_Pagar;
                                        Adeudo_Response_Seleccionado.Fecha_Del_Ultimo_Pago = adeudo_Curso.Fecha_Del_Ultimo_Pago;
                                        Adeudo_Response_Seleccionado.Fecha_Del_Siguiente_Pago = adeudo_Curso.Fecha_Del_Siguiente_Pago;

                                        Cargar_Tabala_Adeudos();
                                        Cargar_Cajas_Con_Informacon_En_Adeudos(Adeudo_Response_Seleccionado);
                                        imprimirRecibo.ImprimirReciboDeAdeudoEstudianteCurso(Adeudo_Response_Seleccionado, Cutota_Adeudo_txt.Text);
                                        Cutota_Adeudo_txt.Text = "";


                                        MessageBox.Show($"El pago de {Cutota_Adeudo_txt.Text} ha sido agregado correctamente al adeudo del estudiante {Nombre_estudiante_Adeudo_txt.Text} en el curso {Nombre_Del_Curso_Adeudo_txt.Text}.", "Pago Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }



                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ha ocurrido un error al agregar la cuota\n" + ex);
                        }
                }

                public DateTime CambiarADia25MesSiguiente( DateTime fechaActual ) {

                        // Sumamos un mes a la fecha actual
                        DateTime siguienteMes = fechaActual.AddMonths(1);

                        // Creamos una nueva fecha con el día 25, manteniendo el año y el mes del siguienteMes
                        DateTime nuevaFecha = new DateTime(siguienteMes.Year, siguienteMes.Month, 25);

                        return nuevaFecha;
                }


                private void Limpiar_Cajas_En_Usuarios_Admins() {
                        Nombre_del_Administrador_txt.Text = "";
                        Apellido_del_Administrador_txt.Text = "";
                        Numero_de_Telefono_txt.Text = "";
                        Pass_Administrador_txt.Text = "";
                        Pass_confirm_administrador_txt.Text = "";
                }

                private async void materialButton24_Click( object sender, EventArgs e ) {

                        var mensaje = MessageBox.Show($"Quiere Agregar al Empleado/Admin {Nombre_del_Administrador_txt.Text}?", "Mensaje de confirmacion para el agregado.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mensaje == DialogResult.No)
                        {
                                return;
                        }


                        try
                        {
                                if (Nombre_del_Administrador_txt.Text == string.Empty)
                                {
                                        MessageBox.Show("Debes ingresar el nombre del administrador", "Error detectado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                }

                                if (Apellido_del_Administrador_txt.Text == string.Empty)
                                {
                                        MessageBox.Show("Debes ingresar el apellido del administrador", "Error detectado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                }

                                if (Numero_de_Telefono_txt.Text == string.Empty)
                                {
                                        MessageBox.Show("Debes ingresar el numero de telefono del administrador", "Error detectado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                }

                                if (Pass_Administrador_txt.Text != Pass_confirm_administrador_txt.Text)
                                {
                                        MessageBox.Show("Las contraseñas no coinciden", "Error detectado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                }

                                Empleado_Admin nuevo_Empleado_Admin = new Empleado_Admin();

                                nuevo_Empleado_Admin.Nombre_del_Administrador = Nombre_del_Administrador_txt.Text;
                                nuevo_Empleado_Admin.Apellido_del_Administrador = Apellido_del_Administrador_txt.Text;
                                nuevo_Empleado_Admin.Numero_de_Telefono = Numero_de_Telefono_txt.Text;
                                nuevo_Empleado_Admin.Pass = Pass_Administrador_txt.Text;
                                nuevo_Empleado_Admin.Pass_confirm = Pass_confirm_administrador_txt.Text;
                                nuevo_Empleado_Admin.Estado = Modules.Enums.Estados_Generales.Activo;
                                nuevo_Empleado_Admin.Cargo = Modules.Enums.Cargos_Empleados_admins.empleado;

                                using (var context = new AppDbContext(OpcionsBuilder_c.getConnection().Options))
                                {
                                        context.Empleado_Admins.Add(nuevo_Empleado_Admin);
                                        await context.SaveChangesAsync();
                                        MessageBox.Show($"El empleado {nuevo_Empleado_Admin.Nombre_del_Administrador} ha sido creado correctamente.", "Empleado Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Cargar_Tabla_De_Usuarios_Admins();
                                        Limpiar_Cajas_En_Usuarios_Admins();
                                        return;

                                }



                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ocurrio un error en el inicio de secion...\n" + ex);
                        }
                }

                private async void materialButton21_Click( object sender, EventArgs e ) {
                        if (empleado_admin_seleccionado == null)
                        {
                                MessageBox.Show("no has seleccionando al empleado", "mensaje de busqueda");
                                return;
                        }
                        var mensaje = MessageBox.Show($"Quieres eliminar al usuario admin {empleado_admin_seleccionado}?", "Mensaje de confirmacion para el agregado.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (mensaje == DialogResult.No)
                        {
                                return;
                        }

                        try
                        {

                                using (var context = new AppDbContext(OpcionsBuilder_c.getConnection().Options))
                                {
                                        empleado_admin_seleccionado.Estado = Estados_Generales.Inactivo;
                                        context.Empleado_Admins.Update(empleado_admin_seleccionado);
                                        await context.SaveChangesAsync();
                                        Cargar_Tabla_De_Usuarios_Admins();
                                        MessageBox.Show($"Se ha eliminado con exito al usuario {empleado_admin_seleccionado}");
                                }



                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ocurrio un error al tratar de eliminar al empleado/admin\n" + ex);
                        }

                }

                Empleado_Admin empleado_admin_seleccionado = new Empleado_Admin();
                long empleado_admin_seleccionado_id = 0;

                private void Usuarios_Empleados_DG_CellClick( object sender, DataGridViewCellEventArgs e ) {
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
                        if (empleado_admin_seleccionado == null)
                        {
                                MessageBox.Show("no has seleccionando al empleado", "mensaje de busqueda");
                                return;
                        }
                        var mensaje = MessageBox.Show($"Quieres editar al usuario admin {empleado_admin_seleccionado}?", "Mensaje de confirmacion para el agregado.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (mensaje == DialogResult.No)
                        {
                                return;
                        }
                        Administrador_empleado_editar administrador_Empleado_Editar = new Administrador_empleado_editar();
                        administrador_Empleado_Editar.empleado_admin_seleccionado = empleado_admin_seleccionado;
                        administrador_Empleado_Editar.empleado_admin_seleccionado_id = empleado_admin_seleccionado_id;
                        administrador_Empleado_Editar.admin = admin;
                        administrador_Empleado_Editar.ShowDialog();


                }

                private void Buscar_Profesor_txt_TextChanged( object sender, EventArgs e ) {
                        string textoBusqueda = Buscar_Profesor_txt.Text.Trim();

                        if (textoBusqueda == "" || Lista_De_Profesores_Blindada.Count == 0)
                        {
                                Cargar_Tabla_Profesores();
                                return;
                        }

                        var query = Lista_De_Profesores_Blindada.Where(x => x.Nombre.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                        if (query == null)
                        {
                                MessageBox.Show("No se encontraron productos con el nombre proporcionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                        }

                        Lista_De_Profesores_Blindada.Clear();
                        Lista_De_Profesores_Blindada = new BindingList<Profesores_Response>(query);
                        Profesores_dg.DataSource = Lista_De_Profesores_Blindada;

                }

                private void Buscar_Cursos_txt_TextAlignChanged( object sender, EventArgs e ) {

                }

                private void Buscar_Cursos_txt_TextChanged( object sender, EventArgs e ) {
                        string textoBusqueda = Buscar_Cursos_txt.Text.Trim();

                        if (textoBusqueda == "" || Cursos_Lista.Count == 0)
                        {
                                CargarTabla_De_Cursos();
                                return;
                        }

                        var query = Cursos_Lista.Where(x => x.Nombre.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                        if (query == null)
                        {
                                MessageBox.Show("No se encontraron Curso con el nombre proporcionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                        }

                        Cursos_Lista.Clear();
                        Cursos_Lista = new BindingList<Cursos_Response>(query);
                        Listado_De_Cursos_dg.DataSource = Cursos_Lista;
                }

                private void materialMaskedTextBox3_TextChanged( object sender, EventArgs e ) {
                        string textoBusqueda = Estudiantes_Busqueda_txt.Text.Trim();

                        if (textoBusqueda == "" || estudiantes_Responses.Count == 0)
                        {
                                Cargar_Tabla_De_Estudiantes();
                                return;
                        }

                        var query = estudiantes_Responses.Where(x => x.Nombre.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                        if (query == null)
                        {
                                MessageBox.Show("No se encontraron Curso con el nombre proporcionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                        }

                        estudiantes_Responses.Clear();
                        estudiantes_Responses = new BindingList<Estudiantes_Response>(query);
                        Estudiantes_dataview.DataSource = estudiantes_Responses;
                }

                private void Pagos_Estudiantes_Buscador_txt_TextChanged( object sender, EventArgs e ) {
                        string textoBusqueda = Pagos_Estudiantes_Buscador_txt.Text.Trim();

                        if (textoBusqueda == "" || adeudo_Responses.Count == 0)
                        {
                                Cargar_Tabala_Adeudos();
                                return;
                        }

                        var query = adeudo_Responses.Where(x => x.Nombre_Curso.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0 || x.Nombre_Estudiante.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                        if (query == null)
                        {
                                MessageBox.Show("No se encontraron Curso con el nombre proporcionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                        }

                        adeudo_Responses.Clear();
                        adeudo_Responses = new BindingList<Adeudo_Response>(query);
                        Adeudo_data_Grid.DataSource = adeudo_Responses;
                }

                private void Usuarios_Busqueda_txt_TextChanged( object sender, EventArgs e ) {
                        string textoBusqueda = Usuarios_Busqueda_txt.Text.Trim();

                        if (textoBusqueda == "" || Usuarios_admins_List.Count == 0)
                        {
                                Cargar_Tabla_De_Usuarios_Admins();
                                return;
                        }

                        var query = Usuarios_admins_List.Where(x => x.Nombre_del_Administrador.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0 || x.Apellido_del_Administrador.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                        if (query == null)
                        {
                                MessageBox.Show("No se encontraron Curso con el nombre proporcionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                        }

                        Usuarios_admins_List.Clear();
                        Usuarios_admins_List = new BindingList<Empleado_Admin_Response>(query);
                        Usuarios_Empleados_DG.DataSource = Usuarios_admins_List;
                }


                List<String> cabeceras_En_Profesores = new List<string>() {
                "ID",
                "Nombre del profesor",
                "Apellido del profesor",
                "Tel. Profeosr",
                "Porcentaje de comision",
                "Pago total de comision",
                "Cursos impartidos",
                "Fecha de agregado",
                "Fecha de integracion al sistema"
                };

                private void materialButton19_Click( object sender, EventArgs e ) {
                        try
                        {
                                GeneradorDePdf.GeneradorDePDFS<Profesores_Response>(Lista_De_Profesores_Blindada, cabeceras_En_Profesores, "Lista_De_Profesores", "PlantillaFactura", "Lista de Profesores");
                                MessageBox.Show("Reporte de profesores generado");
                                return;
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ocurrio un error al generar el reporte de Profesores\n" + ex);
                                return;
                        }
                }
                List<String> cabeceras_En_Cursos = new List<string>() {
                "ID",
                "Nombre del curso",
                "Descripcion del curso",
                "Dia en el que se imparte el curso",
                "Hoara de inicio",
                "Hora de finalizacion",
                "Nombre del Profesor",
                "Cantidad De estudiantes",
                "Costo del curso total",
                "Costo de inscripcion",
                "Estado del curso"
                };
                private void materialButton20_Click( object sender, EventArgs e ) {
                        try
                        {
                                GeneradorDePdf.GeneradorDePDFS<Cursos_Response>(Cursos_Lista, cabeceras_En_Cursos, "Lista_De_Cursos", "PlantillaFactura", "Lista de Cursos");
                                MessageBox.Show("Reporte de Cursos generado");
                                return;
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ocurrio un error al generar el reporte de Cursos\n" + ex);
                                return;
                        }
                }
                List<String> cabeceras_En_Estudiantes = new List<string>() {
                "ID",
                "Nombre del estudiante",
                "Apellido del estudiante",
                "Edad",
                "Genero",
                "Apodo / Sobre nombre",
                "Numero de cedula",
                "Direccion",
                "Municipio",
                "Secctor",
                "Nombre del tutor",
                "Tel. Tutor",
                "Estudia en la actualidad",
                "Nivel de Educacion",
                "Fecha de Inscripcion",
                "Fecha de Insercion Al sistema",
                "Cantidad De cursos inscritos",
                "Empleado que lo inscribio"
                };
                private void materialButton26_Click( object sender, EventArgs e ) {
                        try
                        {
                                GeneradorDePdf.GeneradorDePDFS<Estudiantes_Response>(estudiantes_Responses, cabeceras_En_Estudiantes, "Reporte_De_Estudiantes", "PlantillaFactura", "Lista de Estudiantes");
                                MessageBox.Show("Reporte de Cursos generado");
                                return;
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ocurrio un error al generar el reporte de Cursos\n" + ex);
                                return;
                        }
                }
                List<String> cabeceras_En_Adeudos = new List<string>() {
                "Codigo De la Deuda",
                "Id del estudiante",
                "Nombre del estudiante",
                "Apellido del estudiante",
                "Edad",
                "Numero de cedula",
                "Total pagado",
                "Restante a pagar",
                "Deudo total",
                "Estado del adeudo",
                "Codigo del curso",
                "Nombre del curso",
                "Descripcion del curso",
                "Fecha del ultimo pago",
                "Fecha del siguiente pago"
                };
                private void materialButton27_Click( object sender, EventArgs e ) {
                        try
                        {
                                GeneradorDePdf.GeneradorDePDFS<Adeudo_Response>(adeudo_Responses, cabeceras_En_Adeudos, "Lista_De_Adeudos", "PlantillaFactura", "Lista de Adeudos");
                                MessageBox.Show("Reporte de adeudos generados");
                                return;
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ocurrio un error al generar el reporte de adeudos\n" + ex);
                                return;
                        }
                }
                List<String> cabeceras_En_Empleado_Admin = new List<string>() {
                "ID",
               "Nombre del Empleado",
                    "Apellido del Empleado",
                    "Numero de telefono",
                    "Cotraseña",
                    "Contraseña confirmada",
                    "Estado del Empleado",
                    "Cargo del usuario"
                };

                private void materialButton28_Click( object sender, EventArgs e ) {
                        try
                        {
                                GeneradorDePdf.GeneradorDePDFS<Empleado_Admin_Response>(Usuarios_admins_List, cabeceras_En_Empleado_Admin, "Reporte_Empleado_administrador", "PlantillaFactura", "Lista de Empleados_usuarios");
                                MessageBox.Show("Reporte de Empleado/usuario generados");
                                return;
                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ocurrio un error al generar el reporte de Empleados/usuarios\n" + ex);
                                return;
                        }
                }
        }
}

