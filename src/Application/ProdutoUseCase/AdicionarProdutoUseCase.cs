using Domain.Entities.Produto;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.UseCases.Produto;

namespace Application.ProdutoUseCase
{
    public class AdicionarProdutoUseCase : IAdicionarProdutoUseCase
    {
        private readonly IProdutoRepository _produtoRepository;

        public AdicionarProdutoUseCase(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void Run(ProdutoEntidade produto)
        {
            _produtoRepository.AdicionarProduto(produto);
        }
    }
}
