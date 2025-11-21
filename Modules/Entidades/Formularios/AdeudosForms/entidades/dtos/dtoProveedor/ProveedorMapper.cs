using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoProveedor
{
    public class ProveedorMapper
    {
        // ✅ De Entidad a DTO
        public static ProveedorMostrarDto ToDto(Proveedor entidad)
        {
            int cantidadDeProductos = 0;

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                cantidadDeProductos = context.Productos.Count(p => p.ProveedorId == entidad.Id);
            }

            if (entidad == null) return null;

            return new ProveedorMostrarDto
            {
                Id = entidad.Id,
                Nombre = entidad.Nombre,
                Contacto = entidad.Contacto,
                UltimaCompra = entidad.UltimaCompra,
                FechaCreacion = entidad.FechaDeCreacion,
                CantidadDeProductos = cantidadDeProductos

            };
        }

        // ✅ De DTO a Entidad
        public static Proveedor ToEntity(ProveedorMostrarDto dto)
        {
            if (dto == null) return null;

            return new Proveedor
            {
                Id = dto.Id,
                Nombre = dto.Nombre,
                Contacto = dto.Contacto,
                UltimaCompra = dto.UltimaCompra,
                FechaDeCreacion = dto.FechaCreacion
            };
        }

        // ✅ List<Entidad> → List<DTO>
        public static List<ProveedorMostrarDto> ToDtoList(List<Proveedor> entidades)
        {
            return entidades?.Select(ToDto).ToList();
        }

        // ✅ List<DTO> → List<Entidad>
        public static List<Proveedor> ToEntityList(List<ProveedorMostrarDto> dtos)
        {
            return dtos?.Select(ToEntity).ToList();
        }
    }
}
