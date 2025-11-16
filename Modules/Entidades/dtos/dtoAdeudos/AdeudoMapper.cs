using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoAdeudos
{
    public static class AdeudoMapper
    {
        // ===== ENTIDAD → MOSTRAR =====
        public static AdeudoMostrarDto ToMostrarDto(this Adeudo entity)
        {
            return new AdeudoMostrarDto
            {
                Id = entity.Id,
                MontoTotalDelAdeudo = entity.MontoTotalDelAdeudo,
                MontoTotalAbonadoDelAdeudo = entity.MontoTotalAbonadoDelAdeudo,
                MontoRestanteDelAdeudo = entity.MontoRestanteDelAdeudo,
                FechaCreacion = entity.FechaCreacion,
                FechaUltimaActualizacion = entity.FechaUltimaActualizacion,
                IdCompra = entity.IdCompra
            };
        }

        // ===== ENTIDAD → EDITAR =====
        public static AdeudoEditarDto ToEditarDto(this Adeudo entity)
        {
            return new AdeudoEditarDto
            {
                Id = entity.Id,
                MontoTotalDelAdeudo = entity.MontoTotalDelAdeudo,
                MontoTotalAbonadoDelAdeudo = entity.MontoTotalAbonadoDelAdeudo,
                FechaUltimaActualizacion = DateTime.Now,
                IdCompra = entity.IdCompra
            };
        }

        // ===== ENTIDAD → CREAR =====
        public static AdeudoCrearDto ToCrearDto(this Adeudo entity)
        {
            return new AdeudoCrearDto
            {
                MontoTotalDelAdeudo = entity.MontoTotalDelAdeudo,
                MontoTotalAbonadoDelAdeudo = entity.MontoTotalAbonadoDelAdeudo,
                FechaCreacion = entity.FechaCreacion,
                IdCompra = entity.IdCompra
            };
        }

        // ===== CREAR DTO → ENTIDAD =====
        public static Adeudo ToEntity(this AdeudoCrearDto dto)
        {
            return new Adeudo
            {
                MontoTotalDelAdeudo = dto.MontoTotalDelAdeudo,
                MontoTotalAbonadoDelAdeudo = dto.MontoTotalAbonadoDelAdeudo,
                FechaCreacion = dto.FechaCreacion,
                IdCompra = dto.IdCompra
            };
        }

        // ===== EDITAR DTO → ENTIDAD (UPDATE) =====
        public static void UpdateEntity(this AdeudoEditarDto dto, Adeudo entity)
        {
            entity.MontoTotalDelAdeudo = dto.MontoTotalDelAdeudo;
            entity.MontoTotalAbonadoDelAdeudo = dto.MontoTotalAbonadoDelAdeudo;
            entity.FechaUltimaActualizacion = dto.FechaUltimaActualizacion;
            entity.IdCompra = dto.IdCompra;
        }
    }
}
