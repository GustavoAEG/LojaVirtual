using LojaVirtual.Application.Commands;
using LojaVirtual.Domain.Entities;
using LojaVirtual.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Application.Handlers.Produtos
{
  public class CriarProdutoHandler : IRequestHandler<CriarProdutoCommand,Guid>
    {
        private readonly IProdutoRepository _produtoRepository;

        public CriarProdutoHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<Guid> Handle(CriarProdutoCommand request, CancellationToken cancellationToken)
        {
            var produto = new Produto(
              request.Nome,
              request.Descricao,
              request.Preco,
              request.Estoque,
              request.Tamanho,
              request.Genero,
              request.CategoriaId
          );

            await _produtoRepository.AdicionarAsync(produto);
            return produto.Id;
        }

    }
}
