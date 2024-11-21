using Domain.Entities.Produto;
using Domain.Interfaces.Repositories;

namespace Infraestructure
{
    public class ProdutoRepository : IProdutoRepository
    {
        private static List<ProdutoEntidade> Produtos = UnitOfWork.Produtos;

        public long AdicionarProduto(ProdutoEntidade produto)
        {
            var idProduto = Produtos.Count + 1;
            Produtos.Add(produto);
            return idProduto;
        }

        public ProdutoEntidade? ObterProdutoPorId(long idProduto)
        {
            return Produtos.FirstOrDefault(p => p.Id == idProduto);
        }

        public ProdutoEntidade? ObterProdutoPorNome(string nomeProduto)
        {
            return Produtos.FirstOrDefault(p => p.Nome == nomeProduto);
        }

        public void AtualizarProduto(ProdutoEntidade produto)
        {
            var produtoExistente = Produtos.FirstOrDefault(p => p.Id == produto.Id);
            if (produtoExistente != null)
            {
                Produtos.Remove(produtoExistente);
                Produtos.Add(produto);
            }
        }

        public void RemoverProduto(long idProduto)
        {
            var produtoExistente = Produtos.FirstOrDefault(p => p.Id == idProduto);
            if (produtoExistente != null)
            {
                Produtos.Remove(produtoExistente);
            }
        }

        IEnumerable<ProdutoEntidade> IProdutoRepository.ObterTodosOsProdutos()
        {
            return Produtos;
        }
    }
}
