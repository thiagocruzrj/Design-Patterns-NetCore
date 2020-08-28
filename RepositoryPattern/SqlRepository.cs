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

        public SqlRepository(string _connectionStringId)
        {
            _connectionStringId = _connectionStringId;
        }

        protected SqlConnection Database {
            get {
                if(_connection == null)
                {
                    If(string.IsNullOrEmpty(_connectionString))
                    {
                        _connectionString = _configuration.GetConnectionString(_connectionStringId);
                    }
                    _connection = new SqlConnection(_connectionString);
                }
                return _connection;
            }
        }

        public SqlRepository UseConnectionStringId(string connectionStringId)
        {
            _connectionStringId = connectionStringId;
            return this;
        }

        public SqlRepository UseConnectionString(string connectionString)
        {
            _connectionString = connectionString;
            return this;
        }
    }
}