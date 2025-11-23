using Microsoft.EntityFrameworkCore;
using p_proyect.Modules.Enums;
using System;
using System.Linq;
using System.Windows.Forms;

namespace p_proyect.Modules.Entidades.dtos.dtoAdeudos
{
    public static class AdeudoMapper
    {
        // ===== ENTIDAD → MOSTRAR =====
        public static AdeudoMostrarDto ToMostrarDto(this Adeudo entity)
        {

            string Nombre = "";
            string Numero = "000-000-0000";
            TipoDeCliente tipo = new TipoDeCliente();
            ClienteNormal clienteNormal = new ClienteNormal();
            ClienteEspecial clienteEspecial = new ClienteEspecial();

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {

                clienteNormal = context.ClientesNormales.FirstOrDefault(x => x.Id == entity.IdCliente || x.Contacto == entity.ContactoDelCliente);
                clienteEspecial = context.ClientesEspeciales.FirstOrDefault(x => x.Id == entity.IdCliente || x.Contacto == entity.ContactoDelCliente);

                if (clienteNormal != null && clienteEspecial != null)
                {
                    MessageBox.Show("Este Cliente existe como cliente normal y cliente especial.");
                    return null;
                }

                if (clienteNormal != null)
                {
                    Nombre = clienteNormal.Nombre;
                    Numero = clienteNormal.Contacto.ToString();
                    tipo = TipoDeCliente.ClienteNormal;
                }

                if (clienteEspecial != null)
                {
                    Nombre = clienteEspecial.Nombre;
                    Numero = clienteEspecial.Contacto.ToString();
                    tipo = TipoDeCliente.ClienteEspecial;
                }
            }

            return new AdeudoMostrarDto
            {
                Id = entity.Id,
                MontoTotalDelAdeudo = entity.MontoTotalDelAdeudo,
                MontoTotalAbonadoDelAdeudo = entity.MontoTotalAbonadoDelAdeudo,
                MontoRestanteDelAdeudo = entity.MontoRestanteDelAdeudo,
                FechaCreacion = entity.FechaCreacion,
                FechaUltimaActualizacion = entity.FechaUltimaActualizacion,
                NombreDelCliente = Nombre,
                NumeroDelCliente = Numero,
                IdCompra = entity.IdVenta,
                TipoDeCliente = tipo,

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
                IdCompra = entity.IdVenta
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
                // IdCompra = entity.IdCompra
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
                // IdCompra = dto.IdCompra
            };
        }

        // ===== EDITAR DTO → ENTIDAD (UPDATE) =====
        public static void UpdateEntity(this AdeudoEditarDto dto, Adeudo entity)
        {
            entity.MontoTotalDelAdeudo = dto.MontoTotalDelAdeudo;
            entity.MontoTotalAbonadoDelAdeudo = dto.MontoTotalAbonadoDelAdeudo;
            entity.FechaUltimaActualizacion = dto.FechaUltimaActualizacion;
            // entity.IdCompra = dto.IdCompra;
        }
    }
}
