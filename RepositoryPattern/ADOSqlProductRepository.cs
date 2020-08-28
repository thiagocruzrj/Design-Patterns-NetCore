using Microsoft.Extensions.Configuration;
namespace RepositoryPattern
{
    public sealed class ADOSqlProductRepository : SqlRepository, IProductRepository
    {
        public SqlProductRepository(IConfiguration configuration) :  base(configuration) { }

        public void Insert(Product product) { }
    }
}