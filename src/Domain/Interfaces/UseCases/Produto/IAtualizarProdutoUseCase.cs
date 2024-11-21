using Domain.Entities.Produto;

namespace Domain.Interfaces.UseCases.Produto
{
    public interface IAtualizarProdutoUseCase
    {
        public void Run(ProdutoEntidade produto);
    }
}
