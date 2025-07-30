using LojaVirtual.Domain.Entities; // Ajuste para o namespace correto das entidades
using Microsoft.EntityFrameworkCore;

namespace LojaVirtual.Infrastructure.Models
{
    public partial class LojaVirtualContext : DbContext
    {
        public LojaVirtualContext(DbContextOptions<LojaVirtualContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LojaVirtualContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
