using DesignPatterns.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace RepositoryPattern
{
    public static class RespositoryExtensions
    {
        public static void UserRepository(this IServiceCollection services)
        {
            services.AddSingleton<IProductRepository, DapperSqlProductRepository>();
        }
    }
}