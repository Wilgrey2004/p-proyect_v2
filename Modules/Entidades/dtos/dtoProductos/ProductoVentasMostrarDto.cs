using p_proyect.Modules.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoVentas
{
    public class ProductoVentasMostrarDto
    {
        [DisplayName("Codigo Unico")]
        public int Id { get; set; }
        [DisplayName("Nombre Del Producto")]
        public string Nombre { get; set; }
        [DisplayName("Corigo De barras")]
        public string CodigoBarra { get; set; }
        [DisplayName("Cantidad")]
        public int Stock { get; set; }
        [DisplayName("Unidad de medida")]
        public UnidadMedida unidadMedida { get; set; }

        [DisplayName("Precio por unidad del produucto")]
        public decimal Precio { get; set; }
    }
}
