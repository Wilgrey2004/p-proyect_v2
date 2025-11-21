using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace p_proyect.Modules.Entidades
{
    public class CompraEntity
    {
        public CompraEntity() { }

        [Key]
        public int Id { get; set; }

        public int CantidadDelProducto { get; set; } = 0;

        // Nuevo: reemplaza tu TotalPorElProducto (que se va a calcular siempre)
        public decimal PrecioUnitario { get; set; }

        public decimal TotalPorElProducto => CantidadDelProducto * PrecioUnitario;

        public int IdVenta { get; set; }
        public Ventas Venta { get; set; }

        [ForeignKey("IdProducto")]
        public int IdProducto { get; set; }

        [NotMapped]   // ← EL PUNTO CLAVE
        public Producto ListaDeproductos { get; set; }

        public DateTime FechaCreacio { get; set; }

        // YA NO LA NECESITAS, PERO SI QUIERES LA PUEDO DEJAR
        public decimal CalcularElTotalDelProducto()
        {
            return CantidadDelProducto * PrecioUnitario;
        }
    }
}
