using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoCompras
{
    public class CarritoCompraDto
    {
        public static int Contador = 1;

        public CarritoCompraDto()
        {
            IdCarritoCompras = Contador++;
        }
        public CarritoCompraDto(string panel)
        {
           
        }

        [DisplayName("ID Carrito")]
        public int IdCarritoCompras { get; set; }

        // Identificadores
        //[DisplayName("ID Compra")]
        //public int CompraId { get; set; }

        [DisplayName("ID Producto")]
        public int ProductoId { get; set; }

        // Datos del producto
        [DisplayName("Producto")]
        public string NombreProducto { get; set; }

        [DisplayName("Código de Barra")]
        public string CodigoBarra { get; set; }

        // Operación
        [DisplayName("Cantidad")]
        public int Cantidad { get; set; }

        [DisplayName("Precio Unitario")]
        public decimal PrecioUnitario { get; set; }

        // Totales
        [DisplayName("Total Producto")]
        public decimal TotalProducto => PrecioUnitario * Cantidad;

        [DisplayName("Total")]
        public decimal Total => Cantidad * PrecioUnitario;

        // Información opcional
        [DisplayName("Unidad de Medida")]
        public string UnidadMedida { get; set; }

        [DisplayName("Fecha Agregado")]
        public DateTime FechaAgregado { get; set; }

        public void ReiniciarContador()
        {
            Contador = 1;
        }

        public void RestarUnoAlContador()
        {
            Contador--;
        }
    }
}
