using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace p_proyect.Modules.Entidades
{
    public class Adeudo
    {
        [DisplayName("Codigo Unico del Adeudo")]
        [Key]
        public int Id { get; set; }

        [DisplayName("Monto Total Del Adeudo")]
        public decimal MontoTotalDelAdeudo { get; set; }

        [DisplayName("Abono Total Al Adeudo")]
        public decimal MontoTotalAbonadoDelAdeudo { get; set; }

        [DisplayName("Monto Restante a pagar")]
        public decimal MontoRestanteDelAdeudo {set; get;}

        [DisplayName("Fecha De Creacion del adeudo")]
        public DateTime? FechaCreacion { get; set; }

        [DisplayName("Fecha de la ultima Actualizacion")]
        public DateTime? FechaUltimaActualizacion { get; set; }

        [DisplayName("Codigo Unico de la Venta")]
        [ForeignKey("IdVenta")]
        public int IdVenta { get; set; }

        public Ventas Venta { get; set; }

        [DisplayName("Cliente Asociado al adeudo")]
        public int IdCliente { get; set; }

        [DisplayName("Contacto Del Cliente asociado al adeudo")]
        public string ContactoDelCliente { get; set; }

        public decimal CalcularElmontoRestante()
        {
            return MontoTotalDelAdeudo - MontoTotalAbonadoDelAdeudo;
        }

    }
}
