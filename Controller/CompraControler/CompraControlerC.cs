using Microsoft.EntityFrameworkCore;
using p_proyect.Modules;
using p_proyect.Modules.Entidades;
using p_proyect.Modules.Entidades.dtos.dtoCompras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Controller.CompraControler
{
    public class CompraControlerC
    {
        public async Task<List<Compra>> ObtenerTodasLasComprasAsync()
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {

                return await context.Compras.Include(c => c.Productos).ToListAsync();
            }
        }

        public async Task<Compra> CrearCompraAsync(CompraCrearDto dto)
        {
            if (dto.ClienteEspecialId <= 0)
                throw new ArgumentException("El ID del cliente es obligatorio.");

            if(dto.Productos == null)
                throw new ArgumentException("Los productos son obligatorios.");

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var productos = dto.Productos;

                if (productos.Count == 0)
                    throw new Exception("Los productos enviados no existen.");

                var nuevaCompra = new Compra
                {
                    ClienteEspecialId = dto.ClienteEspecialId,
                    Fecha = DateTime.Now,
                    Productos = productos,
                    Total = productos.Sum(p => p.PrecioVenta)
                };

                context.Compras.Add(nuevaCompra);
                await context.SaveChangesAsync();
                return nuevaCompra;
            } 

            
        }

        public async Task<Compra> EditarCompraAsync(CompraEditarDto dto)
        {
            if (dto.Id <= 0)
                throw new ArgumentException("El ID es obligatorio.");

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var compra = await context.Compras
                    .Include(c => c.Productos)
                    .FirstOrDefaultAsync(c => c.Id == dto.Id);

                if (compra == null)
                    throw new Exception("La compra no existe.");

                if (dto.ClienteEspecialId > 0)
                    compra.ClienteEspecialId = dto.ClienteEspecialId;

                if (dto.Productos != null)
                {
                    var productos = dto.Productos;
                    compra.Productos = productos;
                    compra.Total = productos.Sum(x => x.PrecioVenta);
                }

                context.Compras.Update(compra);
                await context.SaveChangesAsync();
                return compra;
            }
                
        }

        public async Task<Compra> TraerCompraPorIdAsync(int id)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                return await context.Compras
                .Include(c => c.Productos)
                .FirstOrDefaultAsync(c => c.Id == id);
            }
            
        }

        public async Task<bool> EliminarCompraAsync(int id)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var compra = await context.Compras.FirstOrDefaultAsync(c => c.Id == id);

                if (compra == null)
                    return false;

                context.Compras.Remove(compra);
                await context.SaveChangesAsync();
                return true;
            }
                
        }
    }
}

