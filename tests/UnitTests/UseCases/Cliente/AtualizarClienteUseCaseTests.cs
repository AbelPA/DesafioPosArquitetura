using Application.ClienteUseCases;
using Domain.Entities;
using Domain.Entities.Cliente;
using Domain.Interfaces.Repositories;
using Moq;

namespace UnitTests.UseCases.Cliente
{
    public class AtualizarClienteUseCaseTests
    {
        private readonly Mock<IClienteRepository> _clienteRepositoryMock;
        private readonly AtualizarClienteUseCase _atualizarClienteUseCase;

        public AtualizarClienteUseCaseTests()
        {
            _clienteRepositoryMock = new Mock<IClienteRepository>();
            _atualizarClienteUseCase = new AtualizarClienteUseCase(_clienteRepositoryMock.Object);
        }

        [Fact]
        public void Run_ShouldCallAtualizarCliente_WhenClientIsValid()
        {
            // Arrange
            var cliente = new PessoaFisicaEntidade("John Doe", new EnderecoEntidade(0, "Street", 123, "Apt 1", "Neighborhood", "City", "State", "12345-678"), new ContatoEntidade(0,"123456789", "email@example.com"), new DateOnly(1990, 1, 1));

            // Act
            _atualizarClienteUseCase.Run(cliente);

            // Assert
            _clienteRepositoryMock.Verify(repo => repo.AtualizarCliente(cliente), Times.Once);
        }
    }
}