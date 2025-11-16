using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoAdeudos
{
    public class AdeudoEditarDto
    {

        public int Id { get; set; }

        public decimal MontoTotalDelAdeudo { get; set; }
        public decimal MontoTotalAbonadoDelAdeudo { get; set; }

        public DateTime? FechaUltimaActualizacion { get; set; } = DateTime.Now;

        public int IdCompra { get; set; }
    }
}
