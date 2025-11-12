using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Enums
{
    public enum UserRole
    {
        [Display(Name = "Ninguno")]
        None = 0,

        [Display(Name = "Administrador")]
        Administrador = 1,

        [Display(Name = "Empleado")]
        Empleado = 2,

        [Display(Name = "Vendedor")]
        Vendedor = 3,

        [Display(Name = "Gestor de Inventario")]
        GestorDeInventario = 4
    }
}
