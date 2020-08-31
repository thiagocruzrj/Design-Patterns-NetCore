using DesignPatterns.Repository;

namespace DesignPatterns.UnitOfWork.Scenario1
{
    public interface IPaymentRepository : IEntityRepository<Payment> { }
}