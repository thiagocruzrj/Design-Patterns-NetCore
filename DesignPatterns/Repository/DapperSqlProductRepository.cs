using Dapper;
using Microsoft.Extensions.Configuration;

namespace DesignPatterns.Repository
{
    public class DapperSqlProductRepository : SqlRepository, IProductRepository
    {
        public DapperSqlProductRepository(IConfiguration configuration) : base(configuration) { }

        public void Insert(Product product)
        {
            var command = $"INSERT INTO Product (Id, Name) VALUES (@Id, @Name)";

            Database.Execute(command, product);
        }
    }
}