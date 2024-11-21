using Application.ClienteUseCases;
using Domain.Interfaces.Repositories;
using Moq;

namespace UnitTests.UseCases.Cliente
{
    public class RemoverClienteUseCaseTests
    {
        private readonly Mock<IClienteRepository> _clienteRepositoryMock;
        private readonly RemoverClienteUseCase _removerClienteUseCase;

        public RemoverClienteUseCaseTests()
        {
            _clienteRepositoryMock = new Mock<IClienteRepository>();
            _removerClienteUseCase = new RemoverClienteUseCase(_clienteRepositoryMock.Object);
        }

        [Fact]
        public void Run_ShouldCallRemoverCliente_WhenIdIsValid()
        {
            // Arrange
            var idCliente = 1L;

            // Act
            _removerClienteUseCase.Run(idCliente);

            // Assert
            _clienteRepositoryMock.Verify(repo => repo.RemoverCliente(idCliente), Times.Once);
        }
    }
}
