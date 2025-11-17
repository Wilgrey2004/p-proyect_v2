using Microsoft.EntityFrameworkCore;
using p_proyect.Modules;
using p_proyect.Modules.Entidades;
using p_proyect.Modules.Entidades.dtos.dtoClienteNormal;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace p_proyect.Controller.ClienteNormalController
{
    public class ClienteNormalControllerC
    {
        // ============================================================
        // GET: Obtener todos los clientes normales
        // ============================================================
        public async Task<List<ClienteNormalMostrarDto>> ObtenerTodosLosClientesNormalesAsync()
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var listadoOriginal = await context.ClientesNormales.ToListAsync();
                var listaConvertida = new List<ClienteNormalMostrarDto>();
                for (var i = 0; i < listadoOriginal.Count; i++)
                {
                    listaConvertida.Add(ClienteNormalMapper.ToMostrarDto(listadoOriginal[i]));
                }

                return listaConvertida;
            }
        }

        // ============================================================
        // POST: Crear cliente normal
        // ============================================================
        public async Task<ClienteNormal> CrearClienteNormalAsync(ClienteNormalCrearDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Nombre))
                throw new ArgumentException("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(dto.Contacto))
                throw new ArgumentException("El contacto es obligatorio.");

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var nuevo = new ClienteNormal
                {
                    Nombre = dto.Nombre.Trim(),
                    Contacto = dto.Contacto,
                    FechaCreacion = DateTime.Now,
                    //UltimaCompra = dto.UltimaCompra
                };

                context.ClientesNormales.Add(nuevo);
                await context.SaveChangesAsync();
                return nuevo;
            }
        }

        // ============================================================
        // PUT: Editar cliente normal
        // ============================================================
        public async Task<ClienteNormal> EditarClienteNormalAsync(ClienteNormalEditarDto dto)
        {
            if (dto.Id <= 0)
                throw new ArgumentException("El ID es obligatorio.");

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var cliente = await context.ClientesNormales
                    //.Include(c => c.Compra_)
                    .FirstOrDefaultAsync(c => c.Id == dto.Id);

                if (cliente == null)
                    throw new Exception("El cliente no existe.");

                if (dto.Nombre != null) cliente.Nombre = dto.Nombre.Trim();
                if (dto.Contacto != null) cliente.Contacto = dto.Contacto;

                //if (dto.UltimaCompra > 0)
                //    cliente.UltimaCompra = dto.UltimaCompra;

                context.ClientesNormales.Update(cliente);
                await context.SaveChangesAsync();
                return cliente;
            }
        }

        // ============================================================
        // GET: Traer cliente normal por ID
        // ============================================================
        public async Task<ClienteNormal> TraerClienteNormalPorIdAsync(int id)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                return await context.ClientesNormales
                    //.Include(c => c.Compra_)
                    .FirstOrDefaultAsync(c => c.Id == id);
            }
        }

        // ============================================================
        // DELETE: Eliminar cliente normal
        // ============================================================
        public async Task<bool> EliminarClienteNormalAsync(int id)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var cliente = await context.ClientesNormales
                    .FirstOrDefaultAsync(c => c.Id == id);

                if (cliente == null)
                    return false;

                context.ClientesNormales.Remove(cliente);
                await context.SaveChangesAsync();
                return true;
            }
        }
    }
}
