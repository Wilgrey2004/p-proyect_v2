using p_proyect.Modules.Entidades;
using p_proyect.Modules.Entidades.dtos.dtoCompras;
using p_proyect.Utils.Rnc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Codigo de la notificacion")]
        public int Id { get; set; }
        [DisplayName("Nombre o RNC del Cliente")]
        public string NombreDelCliente { get; set; }

        public List<CompraEntity> CarritoDeCompras { get; set; }

        [DisplayName("RNC Del Cliente")]
        public string Rnc { get; set; }
        //public RncLookupResult RNCInfo { get; set; }

        [DisplayName("Venta Afiliada Al Cliente")]
        [ForeignKey("Venta")]
        public int VentaId { get; set; }

        public Ventas Venta { get; set; }

        [DisplayName("Se puede imprimir el Recibo")]
        public bool ImprimirRecibo { get; set; }

        [DisplayName("Fecha de creacion de la notificacion")]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;


    }
}
