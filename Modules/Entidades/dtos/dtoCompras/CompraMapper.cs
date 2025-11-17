using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoCompras
{
    public static class CompraMapper
    {
        // ===== ENTIDAD → MOSTRAR =====
        public static CompraMostrarDto ToMostrarDto(this Compra entity)
        {
            return new CompraMostrarDto
            {
                Id = entity.Id,
                //ClienteEspecialId = entity.ClienteEspecialId,
                Fecha = entity.Fecha,
                Total = entity.Total,
                Productos = entity.Productos
            };
        }

        // ===== ENTIDAD → EDITAR =====
        public static CompraEditarDto ToEditarDto(this Compra entity)
        {
            return new CompraEditarDto
            {
                Id = entity.Id,
                //ClienteEspecialId = entity.ClienteEspecialId,
                Fecha = entity.Fecha,
                Total = entity.Total,
                Productos = entity.Productos
            };
        }

        // ===== ENTIDAD → CREAR =====
        public static CompraCrearDto ToCrearDto(this Compra entity)
        {
            return new CompraCrearDto
            {
                //ClienteEspecialId = entity.ClienteEspecialId,
                Fecha = entity.Fecha,
                Total = entity.Total,
                Productos = entity.Productos
            };
        }

        // ===== CREAR DTO → ENTIDAD =====
        public static Compra ToEntity(this CompraCrearDto dto)
        {
            return new Compra
            {
                //ClienteEspecialId = dto.ClienteEspecialId,
                Fecha = dto.Fecha,
                Total = dto.Total,
                Productos = dto.Productos
            };
        }

        // ===== EDITAR DTO → ENTIDAD (UPDATE) =====
        public static void UpdateEntity(this CompraEditarDto dto, Compra entity)
        {
            //entity.ClienteEspecialId = dto.ClienteEspecialId;
            entity.Fecha = dto.Fecha;
            entity.Total = dto.Total;
            entity.Productos = dto.Productos;
        }
    }
}
