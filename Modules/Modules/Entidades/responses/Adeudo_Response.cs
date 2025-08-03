using p_proyect.Modules.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.responses
{
        public class Adeudo_Response
        {
                [DisplayName("Codigo De la Deuda")]
                public long Id { get; set; }

                [DisplayName("Id del estudiante")]
                public long Id_Estudiante { get; set; }

                [DisplayName("Nombre del estudiante")]
                public string Nombre_Estudiante { get; set; }

                [DisplayName("Apellido del estudiante")]
                public string Apellido_Estudiante { get; set; }

                [DisplayName("Edad")]
                public int Edad_Estudiante { get; set; }
                [DisplayName("Numero de cedula")]
                public string Cedula_Estudiante { get; set; }

                [DisplayName("Total pagado")]
                public decimal Total_Pagado { get; set; } = 0;

                [DisplayName("Restante a pagar")]
                public decimal Restante_A_Pagar { get; set; } = 0;

                [DisplayName("Deudo total")]
                public decimal Adeudo { get; set; } = 0;
                [DisplayName("Curso del adeudo")]
                public Estado_De_Deudas Estado_De_La_Deuda { get; set; } = Estado_De_Deudas.Pendiente;


                public long Id_Curso { get; set; }
                [Required]
                [DisplayName("Nombre del curso")]
                public string Nombre_Curso { get; set; }
                [DisplayName("Descripcion del curso")]
                public string Descripcion_Del_Curso { get; set; }

                [DisplayName("Fecha del ultimo pago")]
                public DateTime Fecha_Del_Ultimo_Pago { get; set; } = DateTime.Now;

                [DisplayName("Fecha del siguiente pago")]
                public DateTime Fecha_Del_Siguiente_Pago { get; set; }
        }
}
