using DesignPatterns.Repository;
using Microsoft.Extensions.Configuration;

namespace DesignPatterns.ServiceLocator
{
    public static class ProductHelper
    {
        public static IProductRepository ProductRepository()
        {
            var repository = DependencyResolver.Current.GetService<IProductRepository>();
            var configuration = DependencyResolver.Current.GetService<IConfiguration>();

            if(repository == null)
            {
                repository = new DapperSqlProductRepository(configuration);
            }

            return repository;
        }
    }
}