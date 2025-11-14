using Microsoft.EntityFrameworkCore;
using p_proyect.Modules;
using p_proyect.Modules.Entidades;
using p_proyect.Modules.Entidades.dtos.dtoProveedor;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_proyect.Controller.ProveedorController
{
    public class ProveedorControllerC
    {

        public ProveedorControllerC() { }

        public async Task<List<ProveedorMostrarDto>> ObtenerTodosLosProveedores()
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var listado_original = await context.Provedores.ToListAsync();
                List<ProveedorMostrarDto> listado_copia = new List<ProveedorMostrarDto>();

                for (int i = 0; i < listado_original.Count; i++)
                {
                    listado_copia.Add(ProveedorMapper.ToDto(listado_original[i]));
                }

                return listado_copia;
            }
        }

        public async Task<Proveedor> TraerUnProveedorAsync(int id)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                return await context.Provedores.FindAsync(id);
            }
        }

        public async Task EliminarProovedor(int id)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                context.Provedores.Remove(await TraerUnProveedorAsync(id));

                var confirmacion = await context.SaveChangesAsync();

                MessageBox.Show("Proveedor eliminado correctamente. Registros afectados: " + confirmacion);
            }
        }

        public async Task CrearProovedor(ProveedorMostrarDto nuevoProovedor)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                await context.Provedores.AddAsync(ProveedorMapper.ToEntity(nuevoProovedor));
                var confirmacion = await context.SaveChangesAsync();
                MessageBox.Show("Proveedor creado correctamente. Registros afectados: " + confirmacion);
            }
            

        }
            
        public async Task ModificarProovedor(ProveedorMostrarDto proovedorModificado)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                context.Provedores.Update(ProveedorMapper.ToEntity(proovedorModificado));
                var confirmacion = await context.SaveChangesAsync();
                MessageBox.Show("Proveedor modificado correctamente. Registros afectados: " + confirmacion);
            }
        }
    }
}
