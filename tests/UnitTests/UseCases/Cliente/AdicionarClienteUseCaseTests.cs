using Application.ClienteUseCases;
using Domain.Entities;
using Domain.Entities.Cliente;
using Domain.Interfaces.Repositories;
using Moq;

namespace UnitTests.UseCases.Cliente
{
    public class AdicionarClienteUseCaseTests
    {
        private readonly Mock<IClienteRepository> _clienteRepositoryMock;
        private readonly AdicionarClienteUseCase _adicionarClienteUseCase;

        public AdicionarClienteUseCaseTests()
        {
            _clienteRepositoryMock = new Mock<IClienteRepository>();
            _adicionarClienteUseCase = new AdicionarClienteUseCase(_clienteRepositoryMock.Object);
        }

        [Fact]
        public void Run_ShouldReturnClientId_WhenClientIsAddedSuccessfully()
        {
            // Arrange
            var cliente = new PessoaFisicaEntidade("John Doe", new EnderecoEntidade(0, "Street", 123, "Apt 1", "Neighborhood", "City", "State", "12345-678"), new ContatoEntidade(0, "123456789", "email@example.com"), new DateOnly(1990, 1, 1));
            var expectedId = 1L;
            _clienteRepositoryMock.Setup(repo => repo.AdicionarCliente(cliente)).Returns(expectedId);

            // Act
            var result = _adicionarClienteUseCase.Run(cliente);

            // Assert
            Assert.Equal(expectedId, result);
            _clienteRepositoryMock.Verify(repo => repo.AdicionarCliente(cliente), Times.Once);
        }
    }
}
