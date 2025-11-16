using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades
{
    public class Compra
    {
        public int Id { get; set; }
        public int ClienteEspecialId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public decimal Total { get; set; }

        public List<Producto> Productos { get; set; }
    }
}
