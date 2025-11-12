using Microsoft.EntityFrameworkCore;
using p_proyect.Modules;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace p_proyect
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ✅ Cadena de conexión desde app.config
            string connString = ConfigurationManager.ConnectionStrings["p_proyect_c"].ConnectionString;

            // ✅ Opciones del DbContext (YA CON PROVIDER)
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(connString);

            // ✅ Probar conexión SQL Server
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL al conectar: " + ex.Message);
                return;
            }

            // ✅ Crear BD y aplicar migraciones
            try
            {
                using (var context = new AppDbContext(optionsBuilder.Options))
                {
                    context.Database.EnsureCreated();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creando BD: " + ex.Message);
                return;
            }

            // ✅ Ejecutamos el formulario principal
            Application.Run(new Main());
        }
    }
}
