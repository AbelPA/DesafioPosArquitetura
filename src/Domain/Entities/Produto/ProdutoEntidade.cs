namespace Domain.Entities.Produto
{
    public class ProdutoEntidade
    {
        public long Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public int Estoque { get; private set; }

        public ProdutoEntidade(long id, string nome, string descricao, decimal preco, int estoque)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
        }
    }
}
