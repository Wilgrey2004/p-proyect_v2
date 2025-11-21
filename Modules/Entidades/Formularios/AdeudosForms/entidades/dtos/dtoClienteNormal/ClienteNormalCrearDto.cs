using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoClienteNormal
{
    public class ClienteNormalCrearDto
    {
        public string Nombre { get; set; }
        public string Contacto { get; set; }

        public int UltimaCompra { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
