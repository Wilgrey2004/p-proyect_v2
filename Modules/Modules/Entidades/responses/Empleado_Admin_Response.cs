using p_proyect.Modules.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.responses
{
        public class Empleado_Admin_Response
        {
                public long Id { get; set; }

                [DisplayName("Nombre del Empleado")]
                public string Nombre_del_Administrador { get; set; }

                [DisplayName("Apellido del Empleado")]
                public string Apellido_del_Administrador { get; set; }

                [DisplayName("Numero de telefono")]
                public string Numero_de_Telefono { get; set; }

                [DisplayName("Cotraseña")]
                public string Pass { get; set; }

                [DisplayName("Contraseña confirmada")]
                public string Pass_confirm { get; set; }

                [DisplayName("Estado del Empleado")]
                public Estados_Generales Estado { get; set; } = Estados_Generales.Activo;


                [DisplayName("Cargo del usuario")]
                public Cargos_Empleados_admins Cargo { get; set; } = Cargos_Empleados_admins.empleado;

        }
}
