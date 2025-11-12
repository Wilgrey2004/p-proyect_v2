using p_proyect.Modules.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoProductos
{
    public class ProductoMostrarDto
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Nombre del Producto")]
        public string Nombre { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Display(Name = "Código de Barra")]
        public string CodigoBarra { get; set; }

        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Display(Name = "Tipo de Venta")]
        public TipoDeVenta TipoDeDeSalida { get; set; }

        [Display(Name = "Cantidad Disponible")]
        public int Cantidad { get; set; }

        [Display(Name = "Stock Mínimo")]
        public int StockMinimo { get; set; }

        [Display(Name = "Stock Máximo")]
        public int StockMaximo { get; set; }

        [Display(Name = "Unidad de Medida")]
        public UnidadMedida UnidadMedida { get; set; }

        [Display(Name = "Precio de Compra")]
        public decimal PrecioCompra { get; set; }

        [Display(Name = "Precio de Venta")]
        public decimal PrecioVenta { get; set; }

        [Display(Name = "Ganancia")]
        public decimal Ganancia { get; set; }

        [Display(Name = "Fecha de Expiración")]
        public DateTime? FechaExpiracion { get; set; }

        [Display(Name = "Ubicación en Almacén")]
        public string Ubicacion { get; set; }

        [Display(Name = "Activo")]
        public bool Activo { get; set; }

        [Display(Name = "ID del Proveedor")]
        public int ProveedorId { get; set; }

        [Display(Name = "Proveedor")]
        public string NombreProveedor { get; set; }
    }
}
