using Application.PedidoUseCases;
using Domain.Interfaces.Repositories;
using Moq;

namespace UnitTests.UseCases.Pedido
{
    public class RemoverPedidoUseCaseTests
    {
        private readonly Mock<IPedidosRepository> _pedidosRepositoryMock;
        private readonly RemoverPedidoUseCase _removerPedidoUseCase;

        public RemoverPedidoUseCaseTests()
        {
            _pedidosRepositoryMock = new Mock<IPedidosRepository>();
            _removerPedidoUseCase = new RemoverPedidoUseCase(_pedidosRepositoryMock.Object);
        }

        [Fact]
        public void Run_ShouldCallRemoverPedido_WhenIdIsValid()
        {
            // Arrange
            var idPedido = 1L;

            // Act
            _removerPedidoUseCase.Run(idPedido);

            // Assert
            _pedidosRepositoryMock.Verify(repo => repo.RemoverPedido(idPedido), Times.Once);
        }
    }
}
