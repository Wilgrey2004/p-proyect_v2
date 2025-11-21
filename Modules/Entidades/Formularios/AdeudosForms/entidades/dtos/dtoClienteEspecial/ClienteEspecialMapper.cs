using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Modules.Entidades.dtos.dtoClienteEspecial
{
    public static class ClienteEspecialMapper
    {
        // ========== ENTIDAD → MOSTRAR ==========
        public static ClienteEspecialMostrarDto ToMostrarDto(this ClienteEspecial entity)
        {
            return new ClienteEspecialMostrarDto
            {
                Id = entity.Id,
                Nombre = entity.Nombre,
                Apellido = entity.Apellido,
                Cedula = entity.Cedula,
                Contacto = entity.Contacto,
                FechaCreacion = entity.FechaCreacion,
                FechaDeEdicion = entity.FechaDeEdicion,
                FechaUltimaActualizacion = entity.FechaUltimaActualizacion,
                EsClienteActivo = entity.EsClienteActivo,
                UltimaCompra = entity.UltimaCompra,
                CantidadDeCompras = entity.CantidadDeCompras,
                TotalCompradoHistorico = entity.TotalCompradoHistorico,
                LimiteDelCredito = entity.LimiteDelCredito,
                CreditoGastado = entity.CreditoGastado,
                CreditoDisponible = entity.CreditoDisponible,
                FechaUltimoPagoCredito = entity.FechaUltimoPagoCredito,
                MontoUltimoPago = entity.MontoUltimoPago,
                DescuentoPersonal = entity.DescuentoPersonal
            };
        }

        // ========== ENTIDAD → EDITAR ==========
        public static ClienteEspecialEditarDto ToEditarDto(this ClienteEspecial entity)
        {
            return new ClienteEspecialEditarDto
            {
                Id = entity.Id,
                Nombre = entity.Nombre,
                Apellido = entity.Apellido,
                Cedula = entity.Cedula,
                Contacto = entity.Contacto,
                EsClienteActivo = entity.EsClienteActivo,
                FechaDeEdicion = DateTime.Now,
                CantidadDeCompras = entity.CantidadDeCompras,
                TotalCompradoHistorico = entity.TotalCompradoHistorico,
                LimiteDelCredito = entity.LimiteDelCredito,
                CreditoGastado = entity.CreditoGastado,
                FechaUltimoPagoCredito = entity.FechaUltimoPagoCredito,
                MontoUltimoPago = entity.MontoUltimoPago,
                DescuentoPersonal = entity.DescuentoPersonal
            };
        }

        // ========== ENTIDAD → CREAR ==========
        public static ClienteEspecialCrearDto ToCrearDto(this ClienteEspecial entity)
        {
            return new ClienteEspecialCrearDto
            {
                Nombre = entity.Nombre,
                Apellido = entity.Apellido,
                Cedula = entity.Cedula,
                Contacto = entity.Contacto,
                LimiteDelCredito = entity.LimiteDelCredito,
                DescuentoPersonal = entity.DescuentoPersonal,
                FechaCreacion = entity.FechaCreacion
            };
        }

        // ========== CREAR DTO → ENTIDAD ==========
        public static ClienteEspecial ToEntity(this ClienteEspecialCrearDto dto)
        {
            return new ClienteEspecial
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                Cedula = dto.Cedula,
                Contacto = dto.Contacto,
                LimiteDelCredito = dto.LimiteDelCredito,
                DescuentoPersonal = dto.DescuentoPersonal,
                FechaCreacion = dto.FechaCreacion,
                EsClienteActivo = true
            };
        }

        // ========== EDITAR DTO → ENTIDAD ==========
        public static void UpdateEntity(this ClienteEspecialEditarDto dto, ClienteEspecial entity)
        {
            entity.Nombre = dto.Nombre;
            entity.Apellido = dto.Apellido;
            entity.Cedula = dto.Cedula;
            entity.Contacto = dto.Contacto;
            entity.EsClienteActivo = dto.EsClienteActivo;
            entity.FechaDeEdicion = dto.FechaDeEdicion;
            entity.CantidadDeCompras = dto.CantidadDeCompras;
            entity.TotalCompradoHistorico = dto.TotalCompradoHistorico;
            entity.LimiteDelCredito = dto.LimiteDelCredito;
            entity.CreditoGastado = dto.CreditoGastado;
            entity.FechaUltimoPagoCredito = dto.FechaUltimoPagoCredito;
            entity.MontoUltimoPago = dto.MontoUltimoPago;
            entity.DescuentoPersonal = dto.DescuentoPersonal;
        }
    }
}
