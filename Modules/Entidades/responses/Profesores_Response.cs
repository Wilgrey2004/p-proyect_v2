using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace p_proyect.Modules.Entidades.responses
{
        public class Profesores_Response
        {

                public long Id { get; set; }

                [DisplayName(  "Nombre del profesor")]
                public string Nombre { get; set; }
                [DisplayName("Apellido del profesor")]
                public string Apellido { get; set; }

                [DisplayName(  "Tel. Profeosr")]
                public string Numero_De_Telefono { get; set; }

                [DisplayName("Porcentaje de comision")]
                public decimal Porcentaje_De_Comision { get; set; } = 0;

                [DisplayName("Pago total de comision")]
                public decimal Pago_Total_De_Comision { get; set; }

                [DisplayName("Cursos impartidos")]
                public int Cursos_Impartidos_Count { get; set; } = 0;


                [DisplayName("Fecha de agregado")]
                public DateTime Fecha_de_agregado_al_sistema { get; set; } = DateTime.Now;

                [DisplayName("Fecha de integracion al sistema")]
                public DateTime Fecha_De_Integracion_al_Sistema { get; set; }
        }
}
