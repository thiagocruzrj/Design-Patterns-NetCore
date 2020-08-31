using DesignPatterns.Repository;

namespace DesignPatterns.UnitOfWork.Scenario1
{
    public interface IRegisterUnitOfWork
    {
        void Insert(Product product, Payment payment);
        IProductRepository ProductRepository { get; }
        IPaymentRepository PaymentRepository { get; }
    }
}