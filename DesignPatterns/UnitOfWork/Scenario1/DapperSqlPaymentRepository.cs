using DesignPatterns.Repository;
using Microsoft.Extensions.Configuration;

namespace DesignPatterns.UnitOfWork.Scenario1
{
    public sealed class DapperSqlPaymentRepository : DapperSqlRepository<Payment>, IPaymentRepository
    {
        public DapperSqlPaymentRepository(IConfiguration configuration) : base(configuration)
        {
            TableName = "Payment";
        }
    }
}