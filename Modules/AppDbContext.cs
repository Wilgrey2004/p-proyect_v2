using Microsoft.EntityFrameworkCore;
using p_proyect.Modules.Entidades;
using System.Configuration;

namespace p_proyect.Modules
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Proveedor> Provedores { get; set; }

        public DbSet<ClienteEspecial> ClientesEspeciales { get; set; }

        public DbSet<Compra> Compras { get; set; }

        public DbSet<Adeudo> Adeudos { get; set; }

        public DbSet<ClienteNormal> ClientesNormales { get; set; }

        public DbSet<CompraEntity> ComprasEntity { get; set; }

        public DbSet<Ventas> Ventas { get; set; }

        public DbSet<NCF> NCFs { get; set; }
        public DbSet<NotificacionDeVenta> NotificacionesDeVentas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // ✅ Solo por si el contexto se crea sin opciones
            if (!optionsBuilder.IsConfigured)
            {
                string connString = ConfigurationManager.ConnectionStrings["p_proyect_c"].ConnectionString;
                optionsBuilder.UseSqlServer(connString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Semilla para usuario administrador
            modelBuilder.Entity<Usuarios>().HasData(
                new Usuarios
                {
                    Id = 100,
                    Nombre = "Admin",
                    Apellido = "origen",
                    Cedula = "No porta",
                    Correo = "Apro24470@gmail.com",
                    Contrasena = "admin123",
                    Rol = Enums.UserRole.Administrador,
                    Activo = true

                }
            );
        }
    }
}
