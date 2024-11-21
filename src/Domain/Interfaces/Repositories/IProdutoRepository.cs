using Domain.Entities.Produto;

namespace Domain.Interfaces.Repositories
{
    public interface IProdutoRepository
    {
        public long AdicionarProduto(ProdutoEntidade produto);
        public ProdutoEntidade? ObterProdutoPorId(long idProduto);
        public ProdutoEntidade? ObterProdutoPorNome(string nomeProduto);
        public IEnumerable<ProdutoEntidade> ObterTodosOsProdutos();
        public void AtualizarProduto(ProdutoEntidade produto);
        public void RemoverProduto(long idProduto);
    }
}
