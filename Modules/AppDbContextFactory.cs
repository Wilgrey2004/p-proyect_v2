using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace p_proyect.Modules
{

        public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
        {
                public AppDbContext CreateDbContext( string[] args ) {

                        string ConnectionString = ConfigurationManager.ConnectionStrings["p_proyect_c"].ConnectionString;
                        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                        optionsBuilder.UseSqlServer(ConnectionString);

                        return new AppDbContext(optionsBuilder.Options);
                }
        }
}
