using p_proyect.Modules.Entidades;
using p_proyect.Modules.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        // Información de identificación
        [Required]
        [MaxLength(150)]
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
        public decimal PrecioVenta { get; set; }

        [NotMapped]
        public decimal Ganancia => PrecioVenta - PrecioCompra;

        // Fecha de expiración (para alimentos/medicinas)
        public DateTime? FechaExpiracion { get; set; }

        // Ubicación dentro del almacén
        [MaxLength(100)]
        public string Ubicacion { get; set; } // Ejemplo: "Estante A3", "Bodega 2"

        // Estado
        public bool Activo { get; set; } = true;

        // Auditoría
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaActualizacion { get; set; }

        // Foreign Key
        [ForeignKey("Proveedor_")]
        public int ProveedorId { get; set; }

        // Navigation Property
        public Proveedor Proveedor_ { get; set; }
    }
}
