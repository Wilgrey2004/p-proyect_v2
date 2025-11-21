using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoCompras
{
    public class CarritoCompraDto
    {
        private static int Contador = 1;
        public CarritoCompraDto()
        {
            IdCarritoCompras = Contador++;
        }

        public int IdCarritoCompras { get; set; }


        // Identificadores
        public int CompraId { get; set; }
        public int ProductoId { get; set; }

        // Datos del producto
        public string NombreProducto { get; set; }
        public string CodigoBarra { get; set; }

        // Operación
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        // Total calculado

       // public decimal PrecioUnitario { get; set; }
        public decimal TotalProducto => PrecioUnitario * Cantidad;

        public decimal Total => Cantidad * PrecioUnitario;

        // Información opcional
        public string UnidadMedida { get; set; }
        public DateTime FechaAgregado { get; set; }
    }
}
