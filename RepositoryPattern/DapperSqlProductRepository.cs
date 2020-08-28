using Dapper;
using Microsoft.Extensions.Configuration;

namespace RepositoryPattern
{
    public class DapperSqlProductRepository : SqlRepository, IProductRepository
    {
        public DapperSqlProductRepository() { }

        public void InsertProduct(Product product)
        {
            var command = $"INSERT INTO Product (Id, Name) VALUES (@Id, @Name)";

            Databaseee.Execute(command, product);
        }
    }
}