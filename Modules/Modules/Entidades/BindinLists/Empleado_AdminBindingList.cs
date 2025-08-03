using Microsoft.EntityFrameworkCore;
using p_proyect.Modules.Entidades.request;
using p_proyect.Modules.Entidades.responses;
using p_proyect.Utils;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;


namespace p_proyect.Modules.Entidades.BindinLists
{
        public class Empleado_AdminBindingList
        {
                private BindingList<Empleado_Admin_Response> Empleado_Admin_List = new BindingList<Empleado_Admin_Response>();

                public BindingList<Empleado_Admin_Response> GetList() {
                        try
                        {


                                using (var context = new AppDbContext(OpcionsBuilder_c.getConnection().Options))
                                {
                                        //var queryCursos = context.Cursos.Include(x => x.Profesor).Where(x => x.Estado_Actual_Del_Curso == Estado.Activo).ToList();
                                        //var queryCursos_R = context.R_Estudiantes_Cursos.Include(es => es.Estudiante).Include(cu => cu.Cursos).ToList();

                                        var query = context.Empleado_Admins.Select(x => new Empleado_Admin_Response {
                                                
                                                Id = x.Id,
                                                Nombre_del_Administrador = x.Nombre_del_Administrador,
                                                Apellido_del_Administrador = x.Apellido_del_Administrador,
                                                Numero_de_Telefono = x.Numero_de_Telefono,
                                                Pass = x.Pass,
                                                Pass_confirm = x.Pass_confirm,
                                                Estado = x.Estado, 
                                                Cargo = x.Cargo

                                        }).ToList();

                                        // Convertimos el resultado a BindingList

                                        Empleado_Admin_List = new BindingList<Empleado_Admin_Response>(query.ToList());
                                        return Empleado_Admin_List;
                                }

                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ocurrio un error en el inicio de secion...\n" + ex);
                                return null;
                        }

                }
                
        }
}
