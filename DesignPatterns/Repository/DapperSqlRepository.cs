using Dapper;
using Microsoft.Extensions.Configuration;

namespace DesignPatterns.Repository
{
    public class DapperSqlRepository<TModel> : SqlRepository
    {
        public DapperSqlRepository(IConfiguration configuration) : base(configuration) { }

        public string TableName { get; set; }

        public virtual void Insert(TModel model)
        {
            var command = $"INSERT INTO {TableName} (Id, Name) VALUES (@Id, @Name)";

            Database.Execute(command, model);
        }
    }
}