using p_proyect.Modules.Enums;
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
    public class ProductoAlDetalle
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        [MaxLength(250)]
        public string Descripcion { get; set; }

        [MaxLength(50)]
        public string CodigoBarra { get; set; }

        [MaxLength(100)]
        public string Marca { get; set; }

        [MaxLength(100)]
        public string Modelo { get; set; }

        [MaxLength(100)]
        public TipoDeVenta TipoDeDeSalida { get; set; }

        // Existencias
        public int Cantidad { get; set; }
        public int StockMinimo { get; set; }
        public int StockMaximo { get; set; }

        [MaxLength(50)]
        public UnidadMedida UnidadMedida { get; set; } // Ejemplo: "Unidad", "Caja", "Litro", "Kg"

        // Información económica
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioCompra { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Precio De venta Total")]

        public decimal PrecioDeVentaTotal { get; set; }
    }
}
