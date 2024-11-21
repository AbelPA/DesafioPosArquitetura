using Domain.Entities.Produto;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.UseCases.Produto;

namespace Application.ProdutoUseCase
{
    public class ObterTodosOsProdutosUseCase : IObterTodosOsProdutosUseCase
    {
        private readonly IProdutoRepository _produtoRepository;
        public ObterTodosOsProdutosUseCase(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public IEnumerable<ProdutoEntidade> Run()
        {
            return _produtoRepository.ObterTodosOsProdutos();
        }
    }
}
