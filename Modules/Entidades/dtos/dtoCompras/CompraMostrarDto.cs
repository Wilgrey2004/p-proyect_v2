using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoCompras
{
    public class CompraMostrarDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("ID del Cliente Especial")]
        public int ClienteEspecialId { get; set; }

        [DisplayName("Fecha de la Compra")]
        public DateTime Fecha { get; set; }

        [DisplayName("Total de la Compra")]
        public decimal Total { get; set; }

        [DisplayName("Productos")]
        public List<Producto> Productos { get; set; }
    }
}
