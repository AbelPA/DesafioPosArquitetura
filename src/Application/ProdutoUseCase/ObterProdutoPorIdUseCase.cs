using Domain.Entities.Produto;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.UseCases.Produto;

namespace Application.ProdutoUseCase
{
    public class ObterProdutoPorIdUseCase : IObterProdutoPorIdUseCase
    {
        private readonly IProdutoRepository produtoRepository;

        public ObterProdutoPorIdUseCase(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public ProdutoEntidade Run(long idProduto)
        {
            return produtoRepository.ObterProdutoPorId(idProduto);
        }
    }
}
