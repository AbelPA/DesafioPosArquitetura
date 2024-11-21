using Domain.Interfaces.Repositories;
using Infraestructure;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.Ioc.Repositories
{
    public static class RepositoryDependencyInjection
    {
        public static void AddRepositoriesServices(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IPedidosRepository, PedidosRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
        }
    }
}
