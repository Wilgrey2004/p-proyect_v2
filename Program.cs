using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design.Internal;
using p_proyect.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

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
                                using (var context = new AppDbContext(optionsBuilder.Options))
                                {
                                        context.Database.Migrate();
                                }
                                
                        } catch(Exception ex)
                        {
                                MessageBox.Show(ex.Message);
                        }

                        
                        Application.Run(new Inicio_De_Secion());
                }
        }
}
