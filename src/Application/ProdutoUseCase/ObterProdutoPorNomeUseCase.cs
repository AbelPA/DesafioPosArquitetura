using Domain.Entities.Produto;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.UseCases.Produto;

namespace Application.ProdutoUseCase
{
    public class ObterProdutoPorNomeUseCase : IObterProdutoPorNomeUseCase
    {

        private readonly IProdutoRepository produtoRepository;

        public ObterProdutoPorNomeUseCase(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public ProdutoEntidade Run(string nomeProduto)
        {
            return produtoRepository.ObterProdutoPorNome(nomeProduto);
        }
    }
}
