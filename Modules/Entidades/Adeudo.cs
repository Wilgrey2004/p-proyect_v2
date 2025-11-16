using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades
{
    public class Adeudo
    {
        [Key]
        public int Id { get; set; }

        public decimal MontoTotalDelAdeudo { get; set; }

        public decimal MontoTotalAbonadoDelAdeudo { get; set; }

        public decimal MontoRestanteDelAdeudo
        {
            get
            {
                return MontoTotalDelAdeudo - MontoTotalAbonadoDelAdeudo;
            }
        }

        public DateTime? FechaCreacion { get; set; }

        public DateTime? FechaUltimaActualizacion { get; set; }

        [ForeignKey("IdCompra")]
        public int IdCompra { get; set; }

        public Compra Compra_ { get; set; }

    }
}
