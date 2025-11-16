using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoAdeudos
{
    public class AdeudoMostrarDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Monto Total del Adeudo")]
        public decimal MontoTotalDelAdeudo { get; set; }

        [DisplayName("Monto Total Abonado del Adeudo")]
        public decimal MontoTotalAbonadoDelAdeudo { get; set; }

        [DisplayName("Monto Restante del Adeudo")]
        public decimal MontoRestanteDelAdeudo { get; set; }

        [DisplayName("Fecha de Creación")]
        public DateTime? FechaCreacion { get; set; }

        [DisplayName("Fecha de Última Actualización")]
        public DateTime? FechaUltimaActualizacion { get; set; }

        [DisplayName("ID de la Compra")]
        public int IdCompra { get; set; }
    }
}
