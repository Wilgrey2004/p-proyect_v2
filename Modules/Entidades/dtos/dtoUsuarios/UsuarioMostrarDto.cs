using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoUsuarios
{
    public class UsuarioMostrarDto
    {
        [DisplayName("Codigo del Usuario")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Nombre { get; set; }

        [DisplayName("Apellido")]
        public string Apellido { get; set; }

        [DisplayName("Numero De Cedula")]
        public string Cedula { get; set; }

        [DisplayName("Correo Electrónico")]
        public string Correo { get; set; }

        [DisplayName("Cargo del usuario")]
        public string Rol { get; set; }

        [DisplayName("Activo")]
        public bool Activo { get; set; }

        [DisplayName("Fecha de Creación")]
        public DateTime FechaCreacion { get; set; }

        [DisplayName("Fecha de Última Edición")]
        public DateTime FechaEdicion { get; set; }

        [DisplayName("Última Vez Activo")]
        public DateTime UltimaVezActivo { get; set; }

        public static UsuarioMostrarDto Convertir(Usuarios u)
        {
            return new UsuarioMostrarDto
            {
                Id = u.Id,
                Nombre = u.Nombre,
                Apellido = u.Apellido,
                Cedula = u.Cedula,
                Correo = u.Correo,
                Rol =  u.Rol.ToString(),
                Activo = u.Activo,
                FechaCreacion = u.FechaCreacion,
                FechaEdicion = u.FechaEdicion,
                UltimaVezActivo = u.UltimaVezActivo
            };
        }

    }
}
