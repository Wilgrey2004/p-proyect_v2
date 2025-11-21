using p_proyect.Modules.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoProductos
{
    public class ProductoEditarDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string CodigoBarra { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public TipoDeVenta TipoDeDeSalida { get; set; }

        public int Cantidad { get; set; }
        public int StockMinimo { get; set; }
        public int StockMaximo { get; set; }
        public UnidadMedida UnidadMedida { get; set; }

        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }

        public DateTime? FechaExpiracion { get; set; }
        public string Ubicacion { get; set; }

        public bool Activo { get; set; }

        public int ProveedorId { get; set; }
    }
}
