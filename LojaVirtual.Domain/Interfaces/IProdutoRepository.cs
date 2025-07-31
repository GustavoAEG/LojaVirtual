using LojaVirtual.Domain.Entities;

namespace LojaVirtual.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task AdicionarAsync(Produto produto);
       
    }
}
