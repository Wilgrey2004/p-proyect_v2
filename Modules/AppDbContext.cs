using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
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
        }
    }
}
