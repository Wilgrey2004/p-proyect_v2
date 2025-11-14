using Microsoft.EntityFrameworkCore;
using p_proyect.Modules;
using p_proyect.Modules.Entidades;
using p_proyect.Modules.Entidades.dtos.dtoUsuarios;
using p_proyect.Modules.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static p_proyect.Modules.Entidades.dtos.dtoUsuarios.EditarUsuarioDto;

namespace p_proyect.Controller.UsuarioController
{
    public class UsuarioControllerC
    {
        public UsuarioControllerC()
        {
        }



        public async Task<List<Usuarios>> ObtenerTodosLosUsuariosAsync()
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {

                return await context.Usuarios.ToListAsync();
            }
        }

        public async Task<Usuarios> CrearUsuariosAsync(UsuarioCreacionDto dto)
        {
            // ✅ 1. Validación de datos esenciales
            if (string.IsNullOrWhiteSpace(dto.Nombre))
                throw new ArgumentException("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(dto.Apellido))
                throw new ArgumentException("El apellido es obligatorio.");

            if (string.IsNullOrWhiteSpace(dto.Cedula))
                throw new ArgumentException("La cédula es obligatoria.");

            if (dto.Cedula.Length > 11)
                throw new ArgumentException("La cédula no puede tener más de 11 caracteres.");

            if (string.IsNullOrWhiteSpace(dto.Correo))
                throw new ArgumentException("El correo es obligatorio.");

            if (string.IsNullOrWhiteSpace(dto.Contrasena))
                throw new ArgumentException("La contraseña es obligatoria.");

            // ✅ 2. Validación del Rol (debe ser un enum válido)
            if (!Enum.IsDefined(typeof(UserRole), dto.Rol))
                throw new ArgumentException("El rol especificado no es válido.");

            // ✅ 3. Crear contexto bien configurado



            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                // ✅ 4. Crear entidad
                var nuevoUsuario = new Usuarios
                {
                    Nombre = dto.Nombre.Trim(),
                    Apellido = dto.Apellido,
                    Cedula = dto.Cedula.Trim(),
                    Correo = dto.Correo.Trim(),
                    Contrasena = dto.Contrasena.Trim(),
                    Rol = dto.Rol,
                    FechaCreacion = DateTime.UtcNow,
                    FechaEdicion = DateTime.UtcNow,
                    UltimaVezActivo = DateTime.UtcNow,
                    Activo = true
                };

                // ✅ 5. Guardar en BD
                context.Usuarios.Add(nuevoUsuario);
                await context.SaveChangesAsync();

                return nuevoUsuario;
            }
        }

        public async Task<Usuarios> EditarUsuariosAsync(EditUsuarioDto dto)
        {
            // ✅ 1. Validar ID
            if (dto.Id <= 0)
                throw new ArgumentException("El ID del usuario es obligatorio.");

            // ✅ 2. Crear contexto
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                // ✅ 3. Buscar usuario existente
                var usuario = await context.Usuarios.FindAsync(dto.Id);

                if (usuario == null)
                    throw new Exception("El usuario no existe.");

                // ✅ 4. Validaciones básicas (solo si envía el campo)

                if (dto.Nombre != null && string.IsNullOrWhiteSpace(dto.Nombre))
                    throw new ArgumentException("El nombre no puede estar vacío.");

                if (dto.Apellido != null && string.IsNullOrWhiteSpace(dto.Apellido))
                    throw new ArgumentException("El apellido no puede estar vacío.");

                if (dto.Cedula != null)
                {
                    if (string.IsNullOrWhiteSpace(dto.Cedula))
                        throw new ArgumentException("La cédula no puede estar vacía.");

                    if (dto.Cedula.Length > 11)
                        throw new ArgumentException("La cédula no puede tener más de 11 caracteres.");
                }

                if (dto.Correo != null && string.IsNullOrWhiteSpace(dto.Correo))
                    throw new ArgumentException("El correo no puede estar vacío.");

                if (dto.Contrasena != null && string.IsNullOrWhiteSpace(dto.Contrasena))
                    throw new ArgumentException("La contraseña no puede estar vacía.");

                if (dto.Rol.HasValue && !Enum.IsDefined(typeof(UserRole), dto.Rol.Value))
                    throw new ArgumentException("El rol especificado no es válido.");

                // ✅ 5. Aplicar solo los campos enviados
                if (dto.Nombre != null) usuario.Nombre = dto.Nombre.Trim();
                if (dto.Apellido != null) usuario.Apellido = dto.Apellido.Trim();
                if (dto.Cedula != null) usuario.Cedula = dto.Cedula.Trim();
                if (dto.Correo != null) usuario.Correo = dto.Correo.Trim();
                if (dto.Contrasena != null) usuario.Contrasena = dto.Contrasena.Trim();
                if (dto.Rol.HasValue) usuario.Rol = (UserRole)dto.Rol.Value;
                if (dto.Activo.HasValue) usuario.Activo = dto.Activo.Value;

                usuario.FechaEdicion = DateTime.UtcNow;
                
                context.Usuarios.Update(usuario);
                // ✅ 6. Guardar cambios
                await context.SaveChangesAsync();

                return usuario;
            }
        }


        public async Task<Usuarios> TraerUsuarioPorId(int id)
        {
            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {

                return await context.Usuarios.FirstOrDefaultAsync(u => u.Id == id);
            }
        }



        public async Task<bool> EliminarUsuarioAsync(int id)
        {

            using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
            {
                // 1. Buscar usuario
                var usuario = await context.Usuarios.FirstOrDefaultAsync(u => u.Id == id);

                // 2. Validar existencia
                if (usuario == null)
                {
                    return false; // No existe
                }

                // 3. Eliminar
                context.Usuarios.Remove(usuario);

                // 4. Guardar cambios
                await context.SaveChangesAsync();

                return true; // Eliminado
            }
        }

    }
}
