using System;

namespace p_proyect.Core.Interfaces
{
    public abstract class ICliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
