using System;

namespace p_proyect.Modules.Entidades.dtos.dtoClienteEspecial
{
    public class ClienteEspecialCrearDto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Contacto { get; set; }

        public decimal LimiteDelCredito { get; set; }
        public decimal DescuentoPersonal { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
