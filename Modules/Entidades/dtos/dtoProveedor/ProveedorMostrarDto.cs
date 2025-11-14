using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoProveedor
{
    public class ProveedorMostrarDto
    {
     
        [DisplayName("Codigo unico del proveedor")]
        public int Id { get; set; }

        [DisplayName("Nombre del proveedor")]
        public string Nombre { get; set; }

        [DisplayName("Contacto con el proveedor")]
        public string Contacto { get; set; }

        [DisplayName("Cantidad de productos")]
        public int CantidadDeProductos { get; set; }

        [DisplayName("Fecha de la ultima compra")]
        public DateTime? UltimaCompra { get; set; }
        
        [DisplayName("Feha de Creacion")]
        public DateTime? FechaDeCreacion { get; set; }  = DateTime.Now;

    }
}
