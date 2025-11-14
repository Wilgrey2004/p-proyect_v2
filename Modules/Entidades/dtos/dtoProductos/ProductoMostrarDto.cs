using p_proyect.Modules.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoProductos
{
    public class ProductoMostrarDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Nombre del Producto")]
        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        [DisplayName("Código de Barra")]
        public string CodigoBarra { get; set; }

        [DisplayName("Marca")]
        public string Marca { get; set; }

        [DisplayName("Modelo")]
        public string Modelo { get; set; }

        [DisplayName("Tipo de Venta")]
        public TipoDeVenta TipoDeDeSalida { get; set; }

        [DisplayName("Cantidad Disponible")]
        public int Cantidad { get; set; }

        [DisplayName("Stock Mínimo")]
        public int StockMinimo { get; set; }

        [DisplayName("Stock Máximo")]
        public int StockMaximo { get; set; }

        [DisplayName("Unidad de Medida")]
        public UnidadMedida UnidadMedida { get; set; }

        [DisplayName("Precio de Compra")]
        public decimal PrecioCompra { get; set; }

        [DisplayName("Precio de Venta")]
        public decimal PrecioVenta { get; set; }

        [DisplayName("Ganancia")]
        public decimal Ganancia { get; set; }

        [DisplayName( "Fecha de Expiración")]
        public DateTime? FechaExpiracion { get; set; }
        [DisplayName("Fecha en la que se agrego al inventario")]

        public DateTime? FechaCreacion { get; set; }

        [DisplayName( "Ubicación en Almacén")]
        public string Ubicacion { get; set; }

        [DisplayName( "Esta disponible")]
        public bool Activo { get; set; }

        //[Display(Name = "ID del Proveedor")]
        //public int ProveedorId { get; set; }

        [DisplayName("Nombre del proveedor")]
        public string NombreProveedor { get; set; }
    }
}
