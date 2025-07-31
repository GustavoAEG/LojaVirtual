using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaVirtual.Domain.Entities;
using LojaVirtual.Domain.Interfaces;
using LojaVirtual.Infrastructure.Models;

namespace LojaVirtual.Infrastructure.Repositories
{
    public class ProdutoRepository:IProdutoRepository
    {
        //implementar.. interface...

        private readonly LojaVirtualContext _context;

        public ProdutoRepository(LojaVirtualContext context)
        {
            _context = context;
        }

        public async Task AdicionarAsync(Produto produto)
        {
            await _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();
        }
    }
}
