using p_proyect.Modules.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace p_proyect.Modules.Entidades
{
    public class Usuarios
    {
        // ------------------------------
        // IDENTIFICADOR
        // ------------------------------

        [Key] // Llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        // ------------------------------
        // INFORMACIÓN PERSONAL
        // ------------------------------

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(11)] // para cédula dominicana: 00000000000
        public string Cedula { get; set; }

        [Required]
        [MaxLength(255)]
        [EmailAddress]
        public string Correo { get; set; }


        // ------------------------------
        // AUTENTICACIÓN
        // ------------------------------

        [Required]
        [MinLength(6)]
        [MaxLength(200)] // si la encriptas, necesitarás más espacio
        public string Contrasena { get; set; }


        // ------------------------------
        // ROL DEL USUARIO (ENUM)
        // ------------------------------

        [Required]
        public UserRole Rol { get; set; }


        // ------------------------------
        // AUDITORÍA
        // ------------------------------

        [Required]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public DateTime FechaEdicion { get; set; }

        public DateTime UltimaVezActivo { get; set; }


        // ------------------------------
        // ESTADO
        // ------------------------------

        public bool Activo { get; set; } = true;
    }
}
