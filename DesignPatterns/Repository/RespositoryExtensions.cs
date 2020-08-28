using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Repository
{
    public static class RespositoryExtensions
    {
        public static void UserRepository(this IServiceCollection services)
        {
            services.AddSingleton<IProductRepository, DapperSqlProductRepository>();
        }
    }
}