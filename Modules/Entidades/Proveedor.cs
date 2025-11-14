using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades
{
    public class Proveedor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; }

        [MaxLength(150)]
        public string Contacto { get; set; }

        public DateTime? UltimaCompra { get; set; }

        public DateTime? FechaDeCreacion { get; set; } = DateTime.MinValue;

        // Relación 1:N → Un proveedor tiene muchos productos
        public List<Producto> Productos { get; set; }
    }
}
