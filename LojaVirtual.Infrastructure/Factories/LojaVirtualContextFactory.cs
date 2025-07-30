using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace LojaVirtual.Infrastructure.Models
{
    public class LojaVirtualContextFactory : IDesignTimeDbContextFactory<LojaVirtualContext>
    {
        public LojaVirtualContext CreateDbContext(string[] args)
        {
            // Lê o appsettings.json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../LojaVirtual"))
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<LojaVirtualContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new LojaVirtualContext(optionsBuilder.Options);
        }
    }
}
