using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoClienteEspecial
{
    public class ClienteEspecialEditarDto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Contacto { get; set; }

        public bool EsClienteActivo { get; set; }
        public decimal DescuentoPersonal { get; set; }

        public DateTime? FechaDeEdicion { get; set; } = DateTime.Now;

        public int CantidadDeCompras { get; set; }
        public decimal TotalCompradoHistorico { get; set; }

        public decimal LimiteDelCredito { get; set; }
        public decimal CreditoGastado { get; set; }

        public decimal CreditoDisponible { get; set; }

        public DateTime? FechaUltimoPagoCredito { get; set; }
        public decimal? MontoUltimoPago { get; set; }

    }
}
