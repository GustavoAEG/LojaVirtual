using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Application.Commands
{
    public class CriarProdutoCommand : IRequest<int>// o Irequest é uma interface doo MediaTR - indica que o command será processado por um handler. retorna tipo T
    {
        public string Nome { get; }
        public string Descricao { get; }
        public decimal Preco { get; }
        public int Estoque { get; }
        public string Tamanho { get; }
        public string Genero { get; }
        public int CategoriaId { get; }

        public CriarProdutoCommand(string nome, string descricao, decimal preco, int estoque, string tamanho, string genero, int categoriaId)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
            Tamanho = tamanho;
            Genero = genero;
            CategoriaId = categoriaId;
        }
    }
}