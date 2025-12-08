using p_proyect.Modules.Entidades;
using p_proyect.Modules.Entidades.dtos.dtoCompras;
using p_proyect.Utils.Rnc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules
{
    public class NotificacionDeVenta
    {
        [Key]
        public int Id { get; set; }

        public string NombreDelCliente { get; set; }

        public List<CompraEntity> CarritoDeCompras { get; set; }

        public RncLookupResult RNCInfo { get; set; }

       
        public Ventas Venta { get; set; }

        public bool ImprimirRecibo { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;


    }
}
