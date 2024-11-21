using Domain.Entities.Produto;

namespace Domain.Interfaces.UseCases.Produto
{
    public interface IAdicionarProdutoUseCase
    {
        public void Run(ProdutoEntidade produto);
    }
}
