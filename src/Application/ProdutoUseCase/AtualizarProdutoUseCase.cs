using Domain.Entities.Produto;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.UseCases.Produto;

namespace Application.ProdutoUseCase
{
    public class AtualizarProdutoUseCase : IAtualizarProdutoUseCase
    {
        private readonly IProdutoRepository _produtoRepository;
        public AtualizarProdutoUseCase(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public void Run(ProdutoEntidade produto)
        {
            _produtoRepository.AtualizarProduto(produto);
        }
    }
}