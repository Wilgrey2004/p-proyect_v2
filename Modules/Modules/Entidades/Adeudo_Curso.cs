using p_proyect.Modules.Enums;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace p_proyect.Modules.Entidades
{
        public class Adeudo_Curso
        {
                [DisplayName("Codigo De la Deuda")]
                [Key]
                [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
                public long Id { get; set; }

                [DisplayName("Curso del adeudo")]
                [ForeignKey("Curso")]
                public long Id_Curso { get; set; }

                public Cursos Curso { get; set; }

                [DisplayName("Codigo del Estudiante")]
                [ForeignKey("Estudiante")]
                public long Id_Estudiante { get; set; }
                public Estudiante Estudiante { get; set; }

                [DisplayName("Total pagado")]
                public decimal Total_Pagado { get; set; } = 0;

                [DisplayName("Restante a pagar")]
                public decimal Restante_A_Pagar { get; set; } = 0;

                [DisplayName("Deudo total")]
                public decimal Adeudo { get; set; } = 0;

                [DisplayName("Estado de la deuda")]
                public Estado_De_Deudas Estado_De_La_Deuda { get; set; } = Estado_De_Deudas.Pendiente;


                [DisplayName("Fecha del ultimo pago")]

                public DateTime Fecha_Del_Ultimo_Pago { get; set; } = DateTime.Now;


                [DisplayName("Fecha del siguiente pago")]
                public DateTime Fecha_Del_Siguiente_Pago { get; set; }

                public Adeudo_Curso( long id_Curso, long id_estudiante ) {

                        this.Adeudo = Curso.Costo_Del_Curso;
                        this.Restante_A_Pagar = Curso.Costo_Del_Curso - Total_Pagado;
                }
                

                public Adeudo_Curso() {
                        
                }
        }
}
