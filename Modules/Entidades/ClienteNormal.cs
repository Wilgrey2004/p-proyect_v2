using Microsoft.Identity.Client;
using p_proyect.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades
{
    public class ClienteNormal : ICliente
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;


        //public int UltimaCompra { get; set; }

        //public Compra Compra_ { get; set; }

    }
}
