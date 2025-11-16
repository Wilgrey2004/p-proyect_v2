using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoClienteNormal
{
    public class ClienteNormalMostrarDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Nombre { get; set; }

        [DisplayName("Contacto")]
        public string Contacto { get; set; }

        [DisplayName("Fecha de Creación")]
        public DateTime FechaCreacion { get; set; }

        [DisplayName("ID de Última Compra")]
        public int UltimaCompra { get; set; }
    }
}
