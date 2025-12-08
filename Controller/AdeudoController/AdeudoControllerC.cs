using Microsoft.EntityFrameworkCore;
using p_proyect.Modules;
using p_proyect.Modules.Entidades;
using p_proyect.Modules.Entidades.dtos.dtoAdeudos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace p_proyect.Controller.AdeudoController
{
    public class AdeudoControllerC
    {

        private async Task<List<AdeudoMostrarDto>> AumentarAdeudoPorTiempo(List<AdeudoMostrarDto> Lista, decimal cantidad)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                DateTime fechaActual = DateTime.Now;

                foreach (var adeudo in Lista)
                {
                    // Verificar si la deuda tiene más de 30 días
                    TimeSpan diferencia = (TimeSpan)(fechaActual - adeudo.FechaCreacion);
                    if (diferencia.Days < 30)
                        continue; // si no tiene más de 30 días, no aumenta

                    // Calcular el porcentaje
                    decimal porciento = adeudo.MontoRestanteDelAdeudo * (cantidad / 100);

                    // Actualizar el DTO
                    adeudo.MontoTotalDelAdeudo += porciento;

                    // Buscar en BD y actualizar
                    var adeudoEntidad = await context.Adeudos.FirstOrDefaultAsync(a => a.Id == adeudo.Id);
                    if (adeudoEntidad != null)
                    {
                        adeudoEntidad.MontoTotalDelAdeudo = adeudo.MontoTotalDelAdeudo;
                        context.Adeudos.Update(adeudoEntidad);
                    }
                }

                await context.SaveChangesAsync();
                return Lista;
            }
        }


        public async Task<List<AdeudoMostrarDto>> ObtenerTodosLosAdeudosAsync()
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                //.Where(x => x.MontoTotalDelAdeudo == x.MontoTotalAbonadoDelAdeudo)
                var listado = await context.Adeudos.ToListAsync();

                var listadoConvertido = new List<AdeudoMostrarDto>();

                foreach (var item in listado)
                {
                    if (item.MontoTotalDelAdeudo == item.MontoTotalAbonadoDelAdeudo) continue;

                    item.MontoRestanteDelAdeudo = item.CalcularElmontoRestante();

                    context.Adeudos.Update(item);

                    await context.SaveChangesAsync();

                    listadoConvertido.Add(AdeudoMapper.ToMostrarDto(item));
                }

                await AumentarAdeudoPorTiempo(listadoConvertido, 10);

                return listadoConvertido;
            }
        }

        public async Task<Adeudo> CrearAdeudoAsync(AdeudoCrearDto dto)
        {
            if (dto.IdCompra <= 0)
                throw new ArgumentException("El ID de la compra es obligatorio.");

            if (dto.MontoTotalDelAdeudo <= 0)
                throw new ArgumentException("El monto total debe ser mayor a 0.");

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var compra = await context.Compras
                    .FirstOrDefaultAsync(c => c.Id == dto.IdCompra);

                if (compra == null)
                    throw new Exception("La compra asociada no existe.");

                var nuevoAdeudo = new Adeudo
                {
                    //IdCompra = dto.IdCompra,
                    MontoTotalDelAdeudo = dto.MontoTotalDelAdeudo,
                    MontoTotalAbonadoDelAdeudo = dto.MontoTotalAbonadoDelAdeudo,
                    FechaCreacion = DateTime.Now,
                    FechaUltimaActualizacion = DateTime.Now,
                    //Compra_ = compra
                };

                context.Adeudos.Add(nuevoAdeudo);
                await context.SaveChangesAsync();

                return nuevoAdeudo;
            }
        }

        public async Task<Adeudo> EditarAdeudoAsync(AdeudoEditarDto dto)
        {
            if (dto.Id <= 0)
                throw new ArgumentException("El ID es obligatorio.");

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var adeudo = await context.Adeudos
                    //.Include(a => a.Compra_)
                    .FirstOrDefaultAsync(a => a.Id == dto.Id);

                if (adeudo == null)
                    throw new Exception("El adeudo no existe.");

                if (dto.MontoTotalDelAdeudo > 0)
                    adeudo.MontoTotalDelAdeudo = dto.MontoTotalDelAdeudo;

                if (dto.MontoTotalAbonadoDelAdeudo > 0)
                    adeudo.MontoTotalAbonadoDelAdeudo = dto.MontoTotalAbonadoDelAdeudo;

                // Si cambia la compra
                if (dto.IdCompra > 0 && dto.IdCompra > 0)
                {
                    var compra = await context.Compras
                        .FirstOrDefaultAsync(c => c.Id == dto.IdCompra);

                    if (compra == null)
                        throw new Exception("La nueva compra asociada no existe.");

                    //adeudo.IdCompra = dto.IdCompra;
                    //adeudo.Compra_ = compra;
                }

                adeudo.FechaUltimaActualizacion = DateTime.Now;

                context.Adeudos.Update(adeudo);
                await context.SaveChangesAsync();

                return adeudo;
            }
        }

        public async Task<Adeudo> TraerAdeudoPorIdAsync(int id)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                return await context.Adeudos
                    // .Include(a => a.Compra_)
                    .FirstOrDefaultAsync(a => a.Id == id);
            }
        }

        public async Task<bool> EliminarAdeudoAsync(int id)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var adeudo = await context.Adeudos.FirstOrDefaultAsync(a => a.Id == id);

                if (adeudo == null)
                    return false;

                context.Adeudos.Remove(adeudo);
                await context.SaveChangesAsync();

                return true;
            }
        }
    }
}
