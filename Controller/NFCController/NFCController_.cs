using Microsoft.EntityFrameworkCore;
using p_proyect.Modules;
using p_proyect.Modules.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_proyect.Controller.NFCController
{
    public class NFCController_
    {
        public async Task<NCF> TraerElUltimoNFC()
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                var ultimoNFC = await context.NCFs
                    .OrderByDescending(nfc => nfc.Id)
                    .FirstOrDefaultAsync();
                return ultimoNFC;
            }
        }


        public async Task<NCF> CrearNFCAsync(NCF nuevoNFC)
        {
            if (nuevoNFC == null)
                throw new ArgumentException("El NCF es obligatorio.");

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                // Asegurar que el IDENTITY lo genere SQL
                nuevoNFC.Id = 0;

                nuevoNFC.SecuenciaDeCaracteres += 1;
                context.NCFs.Add(nuevoNFC);
                await context.SaveChangesAsync();
                return nuevoNFC;
            }
        }


        public async Task<bool> CrearNuevoNFCAsync(NCF nuevo) {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                context.NCFs.Add(nuevo);
              int confirmacion =  await context.SaveChangesAsync();
                
                return confirmacion > 0;
            }

        }

        public async Task<string> TraerparaImprimirNFC()
        {
            // Traer el último NCF existente
            var ultimo = await TraerElUltimoNFC();

            // Crear un NUEVO objeto NCF basado en este
            var nuevo = new NCF
            {
                Serie = ultimo.Serie,
                TipoDeComprovante = ultimo.TipoDeComprovante,
                SecuenciaDeCaracteres = ultimo.SecuenciaDeCaracteres,
                // Id NO se copia. Id = 0 automáticamente.
            };

            // Guardarlo como nuevo NCF
            var guardado = await CrearNFCAsync(nuevo);

            return guardado.ToString();
        }




        public async Task ActualizarNFC(NCF NuevoParaActualizar )
        {
            

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {

                context.NCFs.Add(NuevoParaActualizar);

                await context.SaveChangesAsync();
            }
        }

    }
}
