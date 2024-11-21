using Domain.Entities.Produto;

namespace Domain.Interfaces.UseCases.Produto
{
    public interface IObterTodosOsProdutosUseCase
    {
        public IEnumerable<ProdutoEntidade> Run();
    }
}
