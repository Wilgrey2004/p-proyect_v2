using p_proyect.Core.Interfaces;
using p_proyect.Modules.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades
{
    public class Ventas
    {

       
        [Key]
        public int Id { get; set; }

        public decimal Descuento { get; set; }

        public decimal TotalEntero { get; set; }

        
        public int IdCliente { get; set; }
       

        public decimal MontoDescontado => TotalEntero * (Descuento / 100m);

        public decimal TotalConElDescuento => TotalEntero - (TotalEntero * (Descuento / 100m));

        public DateTime FechaCreacio { get; set; }
        
        public TipoDeVenta Tipo_De_Venta { get; set; }

        public List<CompraEntity> ListadoDeCompras { get; set; }


        public decimal CalcularTotalEntero()
        {
            
            for (int i = 0; i > ListadoDeCompras.Count; i++)
            {
                TotalEntero += ListadoDeCompras[i].TotalPorElProducto;
            }

            return TotalEntero;

        }
    }
}
