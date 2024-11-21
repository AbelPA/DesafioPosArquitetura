using Application.ClienteUseCases;
using Application.PedidoUseCases;
using Application.ProdutoUseCase;
using Domain.Interfaces.UseCases.Cliente;
using Domain.Interfaces.UseCases.Pedido;
using Domain.Interfaces.UseCases.Produto;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.Ioc.UseCases
{
    public static class UseCasesDependencyInjection
    {
        public static void AddUserCasesServices(this IServiceCollection services)
        {
            services.AddScoped<IRemoverClienteUseCase, RemoverClienteUseCase>();
            services.AddScoped<IAdicionarClienteUseCase, AdicionarClienteUseCase>();
            services.AddScoped<IObterClientePorIdUseCase, ObterClientePorIdUseCase>();
            services.AddScoped<IAtualizarClienteUseCase, AtualizarClienteUseCase>();

            services.AddScoped<IAdicionarPedidoUseCase, AdicionarPedidoUseCase>();
            services.AddScoped<IAtualizarPedidoUseCase, AtualizarPedidoUseCase>();
            services.AddScoped<IObterPedidoPorIdUseCase, ObterPedidoPorIdUseCase>();
            services.AddScoped<IRemoverPedidoUseCase, RemoverPedidoUseCase>();

            services.AddScoped<IAdicionarProdutoUseCase, AdicionarProdutoUseCase>();
            services.AddScoped<IAtualizarProdutoUseCase, AtualizarProdutoUseCase>();
            services.AddScoped<IObterProdutoPorIdUseCase, ObterProdutoPorIdUseCase>();
            services.AddScoped<IObterProdutoPorNomeUseCase, ObterProdutoPorNomeUseCase>();
            services.AddScoped<IObterTodosOsProdutosUseCase, ObterTodosOsProdutosUseCase>();
            services.AddScoped<IRemoverProdutoUseCase, RemoverProdutoUseCase>();
        }
    }
}
