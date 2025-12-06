using p_proyect.Core.Interfaces;
using p_proyect.Modules.Enums;
using p_proyect.Utils.Rnc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades
{
    public class Ventas
    {


        [DisplayName("Codigo unico de la venta")]
        [Key]
        public int Id { get; set; }

        [DisplayName("Descuento de la venta")]
        public decimal Descuento { get; set; } = 1;

        [DisplayName("Total de la venta")]
        public decimal TotalEntero { get; set; }

        [DisplayName("Codigo del cliente")]
        public int IdCliente { get; set; }

        [DisplayName("Monto descontado")]
        public decimal MontoDescontado { get; set; }

        [DisplayName("Total con el descuento")]
        public decimal TotalConElDescuento { get; set; }

        [DisplayName("Fecha de Creacion")]
        public DateTime FechaCreacion { get; set; }

        [DisplayName("Tipo de salida")]
        public TipoDeVenta Tipo_De_Venta { get; set; }

        [DisplayName("Tipo de pago")]
        public TipoDePago Pago { get; set; } = TipoDePago.PagoEnEfectivo;

        [DisplayName("RNC")]
        public string RNC { get; set; } = "Sin RNC";



       // public RncLookupResult InfoRnc { get; set; }

        public List<CompraEntity> ListadoDeCompras { get; set; }


        public decimal CalcularTotalEntero()
        {
            decimal total = 0;

            foreach (var compra in ListadoDeCompras)
            {
                total += compra.CantidadDelProducto * compra.PrecioUnitario;
            }

            return total;
        }



        public decimal CaluclarMontoDescontado() => TotalEntero * (Descuento / 100m);

        public decimal CalcularTotalConElDescuento() => TotalEntero - (TotalEntero * (Descuento / 100m));
    }
}
