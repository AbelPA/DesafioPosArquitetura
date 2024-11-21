using Application.ProdutoUseCase;
using Domain.Interfaces.Repositories;
using Moq;

namespace UnitTests.UseCases.Produto
{
    public class RemoverProdutoUseCaseTests
    {
        private readonly Mock<IProdutoRepository> _produtoRepositoryMock;
        private readonly RemoverProdutoUseCase _removerProdutoUseCase;

        public RemoverProdutoUseCaseTests()
        {
            _produtoRepositoryMock = new Mock<IProdutoRepository>();
            _removerProdutoUseCase = new RemoverProdutoUseCase(_produtoRepositoryMock.Object);
        }

        [Fact]
        public void Run_ShouldCallRemoverProduto_WhenIdIsValid()
        {
            // Arrange
            var idProduto = 1L;

            // Act
            _removerProdutoUseCase.Run(idProduto);

            // Assert
            _produtoRepositoryMock.Verify(repo => repo.RemoverProduto(idProduto), Times.Once);
        }
    }
}
