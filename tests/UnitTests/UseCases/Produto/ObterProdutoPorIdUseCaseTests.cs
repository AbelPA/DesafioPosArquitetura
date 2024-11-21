using Application.ProdutoUseCase;
using Domain.Entities.Produto;
using Domain.Interfaces.Repositories;
using Moq;

namespace UnitTests.UseCases.Produto
{
    public class ObterProdutoPorIdUseCaseTests
    {
        private readonly Mock<IProdutoRepository> _produtoRepositoryMock;
        private readonly ObterProdutoPorIdUseCase _obterProdutoPorIdUseCase;

        public ObterProdutoPorIdUseCaseTests()
        {
            _produtoRepositoryMock = new Mock<IProdutoRepository>();
            _obterProdutoPorIdUseCase = new ObterProdutoPorIdUseCase(_produtoRepositoryMock.Object);
        }

        [Fact]
        public void Run_ShouldReturnProduto_WhenProdutoExists()
        {
            // Arrange
            var idProduto = 1L;
            var expectedProduto = new ProdutoEntidade
            (
                idProduto,
                "Produto Teste",
                "Descrição do Produto Teste",
                100.0m,
                10
            );
            _produtoRepositoryMock.Setup(repo => repo.ObterProdutoPorId(idProduto)).Returns(expectedProduto);

            // Act
            var result = _obterProdutoPorIdUseCase.Run(idProduto);

            // Assert
            Assert.Equal(expectedProduto, result);
            _produtoRepositoryMock.Verify(repo => repo.ObterProdutoPorId(idProduto), Times.Once);
        }
    }
}
