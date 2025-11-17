using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace p_proyect.Modules.Entidades
{
    public class CompraEntity
    {
        [Key]
        public int Id { get; set; }

        public int CantidadDelProducto { get; set; }

        public decimal TotalPorElProducto => CantidadDelProducto * TotalPorElProducto;

        public int IdVenta { get; set; }

        public Ventas Venta { get; set; }

        [ForeignKey("IdProducto")]
        public int IdProducto { get; set; }
        public Producto ListaDeproductos { get; set; }

        public DateTime FechaCreacio { get; set; }


        //public decimal Descuento { get; set; }

        //public decimal TotalEntero { get; set; }

        //public decimal MontoDescontado => TotalEntero * (Descuento / 100m);

        // public decimal TotalConElDescuento => TotalEntero - (TotalEntero * (Descuento / 100m));

    }
}
