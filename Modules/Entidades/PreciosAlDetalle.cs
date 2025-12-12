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
    public class PreciosAlDetalle
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Precio 1")]
        public decimal PrimerPrecio { get; set; }

        [DisplayName("Precio 2")]
        public decimal SegundoPrecio { get; set; }

        [DisplayName("Precio 3")]
        public decimal TercerPrecio { get; set; }

        [DisplayName("Precio 4")]
        public decimal CuartoPrecio { get; set; }

        [DisplayName("Precio 5")]
        public decimal QuintoPrecio { get; set; }

        [ForeignKey("IdProducto")]
        public int IdProducto { get; set; }

        public Producto ProductoAlDetalle { get; set; }
    }
}
