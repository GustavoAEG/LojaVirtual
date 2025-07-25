namespace LojaVirtual.Domain.Entities
{
    public class Produto
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public int Estoque { get; private set; }
        public string Tamanho { get; private set; }
        public string Genero { get; private set; }
        public Guid CategoriaId { get; private set; }

        public Categoria Categoria { get; set; }

        public Produto(string nome, string descricao, decimal preco, int estoque, string tamanho, string genero, Guid categoriaId)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
            Tamanho = tamanho;
            Genero = genero;
            CategoriaId = categoriaId;
        }

        public void AtualizarEstoque(int quantidade)
        {
            Estoque += quantidade;
        }

        public void DebitarEstoque(int quantidade)
        {
            if (quantidade > Estoque)
                throw new InvalidOperationException("Estoque insuficiente.");

            Estoque -= quantidade;
        }
    }
}
