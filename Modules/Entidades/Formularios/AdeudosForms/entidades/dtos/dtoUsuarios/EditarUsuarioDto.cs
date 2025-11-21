using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoUsuarios
{
    public class EditarUsuarioDto
    {

        public class EditUsuarioDto
        {
            public int Id { get; set; }         // Requerido
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Cedula { get; set; }
            public string Correo { get; set; }
            public string Contrasena { get; set; }
            public int? Rol { get; set; }
            public bool? Activo { get; set; }
        }

    }


}
