using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoClienteEspecial
{
    public class ClienteEspecialMostrarDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Nombre { get; set; }

        [DisplayName("Apellido")]
        public string Apellido { get; set; }

        [DisplayName("Cédula")]
        public string Cedula { get; set; }

        [DisplayName("Contacto")]
        public string Contacto { get; set; }

        [DisplayName("Fecha de Creación")]
        public DateTime FechaCreacion { get; set; }

        [DisplayName("Fecha de Edición")]
        public DateTime? FechaDeEdicion { get; set; }

        [DisplayName("Última Actualización")]
        public DateTime? FechaUltimaActualizacion { get; set; }

        [DisplayName("Cliente Activo")]
        public bool EsClienteActivo { get; set; }

        [DisplayName("Última Compra")]
        public DateTime? UltimaCompra { get; set; }

        [DisplayName("Cantidad de Compras")]
        public int CantidadDeCompras { get; set; }

        [DisplayName("Total Comprado Histórico")]
        public decimal TotalCompradoHistorico { get; set; }

        [DisplayName("Límite del Crédito")]
        public decimal LimiteDelCredito { get; set; }

        [DisplayName("Crédito Gastado")]
        public decimal CreditoGastado { get; set; }

        [DisplayName("Crédito Disponible")]
        public decimal CreditoDisponible { get; set; }

        [DisplayName("Fecha del Último Pago de Crédito")]
        public DateTime? FechaUltimoPagoCredito { get; set; }

        [DisplayName("Monto Último Pago")]
        public decimal? MontoUltimoPago { get; set; }

        [DisplayName("Descuento Personal")]
        public decimal DescuentoPersonal { get; set; }
    }

}
