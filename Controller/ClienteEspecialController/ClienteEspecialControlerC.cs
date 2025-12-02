using Microsoft.EntityFrameworkCore;
using p_proyect.Modules;
using p_proyect.Modules.Entidades;
using p_proyect.Modules.Entidades.dtos.dtoClienteEspecial;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace p_proyect.Controller.ClienteEspecialController
{
    public class ClienteEspecialControllerC
    {
        // ============================================================
        // GET: Obtener todos los clientes especiales
        // ============================================================
        public async Task<List<ClienteEspecialMostrarDto>> ObtenerTodosLosClientesEspecialesAsync()
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var listad = await context.ClientesEspeciales.ToListAsync();

                var listadoConvertido = new List<ClienteEspecialMostrarDto>();

                for (int i = 0; i < listad.Count; i++) { 
                    listadoConvertido.Add(ClienteEspecialMapper.ToMostrarDto(listad[i]));
                }

                return listadoConvertido;
            }
        }

        // ============================================================
        // POST: Crear cliente especial
        // ============================================================
        public async Task<ClienteEspecial> CrearClienteEspecialAsync(ClienteEspecialCrearDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Nombre))
                throw new ArgumentException("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(dto.Apellido))
                throw new ArgumentException("El apellido es obligatorio.");

            if (string.IsNullOrWhiteSpace(dto.Cedula))
                throw new ArgumentException("La cédula es obligatoria.");

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var nuevo = new ClienteEspecial
                {
                    Nombre = dto.Nombre.Trim(),
                    Apellido = dto.Apellido.Trim(),
                    Cedula = dto.Cedula.Trim(),
                    Contacto = dto.Contacto,
                    FechaCreacion = DateTime.Now,
                    EsClienteActivo = true,
                    LimiteDelCredito = dto.LimiteDelCredito,
                    CreditoGastado = 0,
                    DescuentoPersonal = dto.DescuentoPersonal,
                    CantidadDeCompras = 0,
                    TotalCompradoHistorico = 0,
                    HistorialCompras = new List<Compra>()
                };

                context.ClientesEspeciales.Add(nuevo);
                await context.SaveChangesAsync();
                return nuevo;
            }
        }

        // ============================================================
        // PUT: Editar cliente especial
        // ============================================================
        public async Task<ClienteEspecial> EditarClienteEspecialAsync(ClienteEspecialEditarDto dto)
        {
            if (dto.Id <= 0)
                throw new ArgumentException("El ID es obligatorio.");

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var cliente = await context.ClientesEspeciales.FirstOrDefaultAsync(c => c.Id == dto.Id);

                if (cliente == null)
                    throw new Exception("El cliente no existe.");

                if (dto.Nombre != null) cliente.Nombre = dto.Nombre.Trim();

                if (dto.Apellido != null) cliente.Apellido = dto.Apellido.Trim();

                if (dto.Cedula != null) cliente.Cedula = dto.Cedula.Trim();

                if (dto.Contacto != null) cliente.Contacto = dto.Contacto;

                if (dto.LimiteDelCredito > 0)
                    cliente.LimiteDelCredito = dto.LimiteDelCredito;

                if (dto.CreditoGastado > 0)
                    cliente.CreditoGastado = dto.CreditoGastado;

                if (dto.DescuentoPersonal > 0)
                    cliente.DescuentoPersonal = dto.DescuentoPersonal;

                if (dto.EsClienteActivo)
                    cliente.EsClienteActivo = dto.EsClienteActivo;

                //if (dto.CreditoDisponible > 0)
                //    cliente.CreditoDisponible = dto.CreditoDisponible;

                cliente.FechaDeEdicion = DateTime.Now;
                cliente.FechaUltimaActualizacion = DateTime.Now;

                context.ClientesEspeciales.Update(cliente);

                await context.SaveChangesAsync();

                return cliente;
            }
        }

        // ============================================================
        // GET: Traer cliente especial por ID
        // ============================================================
        public async Task<ClienteEspecial> TraerClienteEspecialPorIdAsync(int id)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                return await context.ClientesEspeciales
                    .Include(c => c.HistorialCompras)
                    .FirstOrDefaultAsync(c => c.Id == id);
            }
        }

        // ============================================================
        // DELETE: Eliminar cliente especial
        // ============================================================
        public async Task<bool> EliminarClienteEspecialAsync(int id)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var cliente = await context.ClientesEspeciales.FirstOrDefaultAsync(c => c.Id == id);

                if (cliente == null)
                    return false;

                context.ClientesEspeciales.Remove(cliente);
                await context.SaveChangesAsync();
                return true;
            }
        }
    }
}
