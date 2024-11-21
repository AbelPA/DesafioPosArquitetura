using Domain.Interfaces.Repositories;
using Domain.Interfaces.UseCases.Produto;

namespace Application.ProdutoUseCase
{
    public class RemoverProdutoUseCase : IRemoverProdutoUseCase
    {
        private readonly IProdutoRepository _produtoRepository;

        public RemoverProdutoUseCase(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void Run(long idProduto)
        {
            _produtoRepository.RemoverProduto(idProduto);
        }
    }
}
