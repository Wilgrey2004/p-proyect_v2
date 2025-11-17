using System;

namespace p_proyect.Modules.Entidades.dtos.dtoClienteNormal
{
    public static class ClienteNormalMapper
    {
        // ===== ENTIDAD → MOSTRAR =====
        public static ClienteNormalMostrarDto ToMostrarDto(this ClienteNormal entity)
        {
            return new ClienteNormalMostrarDto
            {
                Id = entity.Id,
                Nombre = entity.Nombre,
                Contacto = entity.Contacto,
                FechaCreacion = entity.FechaCreacion,
               
            };
        }

        // ===== ENTIDAD → EDITAR =====
        public static ClienteNormalEditarDto ToEditarDto(this ClienteNormal entity)
        {
            return new ClienteNormalEditarDto
            {
                Id = entity.Id,
                Nombre = entity.Nombre,
                Contacto = entity.Contacto,
               
                FechaDeEdicion = DateTime.Now
            };
        }

        // ===== ENTIDAD → CREAR =====
        public static ClienteNormalCrearDto ToCrearDto(this ClienteNormal entity)
        {
            return new ClienteNormalCrearDto
            {
                Nombre = entity.Nombre,
                Contacto = entity.Contacto,
               
                FechaCreacion = entity.FechaCreacion
            };
        }

        // ===== CREAR DTO → ENTIDAD =====
        public static ClienteNormal ToEntity(this ClienteNormalCrearDto dto)
        {
            return new ClienteNormal
            {
                Nombre = dto.Nombre,
                Contacto = dto.Contacto,
                
                FechaCreacion = dto.FechaCreacion
            };
        }

        // ===== EDITAR DTO → ENTIDAD (UPDATE) =====
        public static void UpdateEntity(this ClienteNormalEditarDto dto, ClienteNormal entity)
        {
            entity.Nombre = dto.Nombre;
            entity.Contacto = dto.Contacto;
            
        }
    }
}
