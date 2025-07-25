﻿namespace LojaVirtual.Domain.Entities
{
    public class Categoria
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }

        public ICollection<Produto> Produtos { get; set; }

        public Categoria(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Produtos = new List<Produto>();
        }
    }
}
