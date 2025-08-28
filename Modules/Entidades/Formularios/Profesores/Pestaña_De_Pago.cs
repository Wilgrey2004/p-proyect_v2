using Bunifu.UI.WinForms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
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

namespace p_proyect.Modules.Entidades.Formularios.Profesores
{
        public partial class Pestaña_De_Pago : MaterialForm
        {

                public Profesor Profesor_Seleccionado;
                private double total_A_Pagar_Por_Comision = 0;
                private int numero_de_estudiantes = 0;
                private int numero_de_Cursos = 0;
                public Pestaña_De_Pago() {
                        InitializeComponent();

                        var materialSkinManager = MaterialSkinManager.Instance;
                        materialSkinManager.AddFormToManage(this);
                        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber600, Primary.Amber700, Primary.Amber800, Accent.LightBlue400, TextShade.BLACK);

                }

                private void Pestaña_De_Pago_Load( object sender, EventArgs e ) {
                        if (Profesor_Seleccionado == null)
                        {
                                MessageBox.Show("No hay profesor seleccionado", "mensaje de busqueda");
                                return;
                        }

                        try
                        {

                                using (var context = new AppDbContext(OpcionsBuilder_c.getConnection().Options))
                                {
                                        var query = context.Cursos.Include(x => x.Profesor).Where(x => x.Profesor_Id == Profesor_Seleccionado.Id).ToList();

                                         total_A_Pagar_Por_Comision = 0;

                                        foreach (var item in query)
                                        {
                                                total_A_Pagar_Por_Comision += (double)(item.Costo_Del_Curso * item.Cantidad_De_Estudiantes * item.Profesor.Porcentaje_De_Comision / 100);
                                                numero_de_estudiantes += item.Cantidad_De_Estudiantes;
                                                numero_de_Cursos++;
                                        
                                        }

                                        chart1.Series[0].Points.Clear();

                                        foreach (var curso in query)
                                        {
                                                double comisionCurso = (double)(curso.Costo_Del_Curso *
                                                                                curso.Cantidad_De_Estudiantes *
                                                                                curso.Profesor.Porcentaje_De_Comision / 100);

                                                chart1.Series[0].Points.AddXY(curso.Nombre, comisionCurso);
                                        }
                                        Cambiar_El_Size_Del_label(label_nombre);
                                        Cambiar_El_Size_Del_label(label_cantidad_estudiantes);
                                        Cambiar_El_Size_Del_label(label_Cursos_impartidos);
                                        Cambiar_El_Size_Del_label(label_Total_A_Pagar);
                                        label_nombre.Text = $"Nombre del profesor: {Profesor_Seleccionado.Nombre} {Profesor_Seleccionado.Apellido}";
                                        label_cantidad_estudiantes.Text = $"Cantidad total de estudiantes: {numero_de_estudiantes}";
                                        label_Cursos_impartidos.Text = $"Cantidad de cursos impartidos: {numero_de_Cursos}";
                                        label_Total_A_Pagar.Text = $"Total a pagar por comision: {total_A_Pagar_Por_Comision.ToString()}";
                                        //MessageBox.Show($"El total de comision ganado por el profesor {Profesor_Seleccionado.Nombre} es de: {total_A_Pagar_Por_Comision.ToString("C2")}\nDebido a que el profesor imparte un total de {numero_de_Cursos} cursos con un total de {numero_de_estudiantes} estudiantes", "Total de comision ganado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }



                        } catch (Exception ex)
                        {
                                MessageBox.Show("ha ocurrido un error al pagar al profesor\n" + ex);
                        }
                }


                private void Cambiar_El_Size_Del_label( BunifuLabel label ) {
                        label.Invoke((MethodInvoker)(() => {
                                label.AutoSize = false;
                                label.Invoke((MethodInvoker)(() => label.TextAlign = (BunifuLabel.TextAlignments)ContentAlignment.TopRight));
                                label.Font = new Font("Segoe UI", 14, FontStyle.Bold); // opcional
                        }));
                }

                private void materialFloatingActionButton1_Click( object sender, EventArgs e ) {
                        if (Profesor_Seleccionado == null)
                        {
                                MessageBox.Show("No hay profesor seleccionado", "mensaje de busqueda");
                                return;
                        }

                        var mensaje = MessageBox.Show($"Quieres Ecribirle por whatsApp al profesor {Profesor_Seleccionado.Nombre}? ", "Mensaje de confirmacion para el agregado.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mensaje == DialogResult.No)
                        {
                                return;
                        }

                        Enviar_Mensaje_A_Ws.EnviarMensaje(Profesor_Seleccionado.Numero_De_Telefono);
                }
        }
}
