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
        public class Adeudo_Estudiantes_BindingList
        {
                private BindingList<Adeudo_Response> Cursos_Lista = new BindingList<Adeudo_Response>();

                public BindingList<Adeudo_Response> GetList() {
                        try
                        {


                                using (var context = new AppDbContext(OpcionsBuilder_c.getConnection().Options))
                                {
                                        //var queryCursos = context.Cursos.Include(x => x.Profesor).Where(x => x.Estado_Actual_Del_Curso == Estado.Activo).ToList();
                                        //var queryCursos_R = context.R_Estudiantes_Cursos.Include(es => es.Estudiante).Include(cu => cu.Cursos).ToList();

                                        var query = context.Adeudos_Cursos.Include(x => x.Estudiante).Include(x => x.Curso).Select(x => new Adeudo_Response {
                                                Id = x.Id,
                                                Nombre_Curso = x.Curso.Nombre,
                                                Descripcion_Del_Curso = x.Curso.Descripcion,
                                                Nombre_Estudiante = x.Estudiante.Nombre,
                                                Apellido_Estudiante = x.Estudiante.Apellido,
                                                Edad_Estudiante = x.Estudiante.Edad,
                                                Cedula_Estudiante = x.Estudiante.Cedula,

                                                Total_Pagado = x.Total_Pagado,
                                                Restante_A_Pagar = x.Restante_A_Pagar,
                                                Adeudo = x.Adeudo,
                                                Estado_De_La_Deuda = x.Estado_De_La_Deuda,
                                                Id_Curso = x.Id_Curso,
                                                Id_Estudiante = x.Id_Estudiante,

                                                Fecha_Del_Ultimo_Pago = x.Fecha_Del_Ultimo_Pago,
                                                
                                                Fecha_Del_Siguiente_Pago = x.Fecha_Del_Siguiente_Pago


                                        }).ToList();

                                        // Convertimos el resultado a BindingList

                                        Cursos_Lista = new BindingList<Adeudo_Response>(query.ToList());
                                        return Cursos_Lista;
                                }

                        } catch (Exception ex)
                        {
                                MessageBox.Show("Ocurrio un error en el inicio de secion...\n" + ex);
                                return null;
                        }

                }
                
        }
}
