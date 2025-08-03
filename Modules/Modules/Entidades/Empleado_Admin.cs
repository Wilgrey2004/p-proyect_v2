using p_proyect.Modules.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace p_proyect.Modules.Entidades
{
        public class Empleado_Admin
        {
                [Key]
                [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
                public long Id { get; set; }

                [DisplayName("Nombre del Empleado")]
                public string Nombre_del_Administrador { get; set; }

                [DisplayName("Apellido del Empleado")]
                public string Apellido_del_Administrador { get; set; }

                [DisplayName("Numero de telefono")]
                public string Numero_de_Telefono { get; set; }

                [DisplayName(  "Cotraseña")]
                public string Pass { get; set; }

                [DisplayName(  "Contraseña confirmada")]
                public string Pass_confirm { get; set; }

                [DisplayName("Estado del Empleado")]
                public Estados_Generales Estado { get; set; } = Estados_Generales.Activo;


                [DisplayName("Cargo del usuario")]
                public Cargos_Empleados_admins Cargo { get; set; } = Cargos_Empleados_admins.empleado;

                public override string ToString() {
                        return $"{Nombre_del_Administrador} {Apellido_del_Administrador}";
                }

        }
}
