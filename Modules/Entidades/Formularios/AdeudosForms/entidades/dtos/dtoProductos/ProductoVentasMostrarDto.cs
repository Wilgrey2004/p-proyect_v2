using p_proyect.Modules.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoVentas
{
    public class ProductoVentasMostrarDto
    {
        public int Id { get; set; }

        public string Nombre { get; set; } 

        public string CodigoDelProducto { get; set; }

        public int Stock { get; set; }


        public UnidadMedida unidadMedida { get; set; }

        public decimal Precio { get; set; }
    }
}
