using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace RepositoryPattern
{
    public abstract class SqlRepository
    {
        private SqlConnection _connection = null;
        private string _connectionStringId;
        private string _connectionString;
        private readonly IConfiguration _configuration;

        public SqlRepository(IConfiguration configuration) : this("RealLifeSample")
        {
            _configuration = configuration;
        }
    }
}