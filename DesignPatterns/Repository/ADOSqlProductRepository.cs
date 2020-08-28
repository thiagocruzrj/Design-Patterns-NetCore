using Microsoft.Extensions.Configuration;
using RepositoryPattern;

namespace DesignPatterns.Repository
{
    public sealed class ADOSqlProductRepository : SqlRepository, IProductRepository
    {
        public ADOSqlProductRepository(IConfiguration configuration) : base(configuration) { }

        public void Insert(Product product) { }
    }
}