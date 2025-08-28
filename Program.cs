using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design.Internal;
using p_proyect.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace p_proyect
{
        internal static class Program
        {
                
                [STAThread]
                static void Main() {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                       
                        string connString = ConfigurationManager.ConnectionStrings["p_proyect_c"].ConnectionString;
                        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                        optionsBuilder.UseSqlServer(connString);



                        try
                        {
                                using (SqlConnection conn = new SqlConnection(connString))
                                {
                                        conn.Open();
                                }
                        } catch (SqlException ex)
                        {
                                Console.WriteLine("Error SQL: " + ex.Message);
                        }


                        try
                        {
                                using (var context = new AppDbContext(optionsBuilder.Options))
                                {
                                        context.Database.Migrate();
                                        context.Database.EnsureCreated();

                                }

                        } catch(Exception ex)
                        {
                                MessageBox.Show(ex.Message);
                        }

                        
                        Application.Run(new Inicio_De_Secion());
                }
        }
}
