using DesignPatterns.Repository;

namespace DesignPatterns.UnitOfWork.Scenario1
{
    public class RegisterUnitOfWork : IRegisterUnitOfWork
    {
        private readonly IProductRepository _productRepository;
        private readonly IPaymentRepository _paymentRepository;

        public RegisterUnitOfWork(IProductRepository productRepository, IPaymentRepository paymentRepository)
        {
            _productRepository = productRepository;
            _paymentRepository = paymentRepository;
        }

        public IPaymentRepository PaymentRepository
        {
            get
            {
                return _paymentRepository;
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                return _productRepository;
            }

        }

        public void Insert(Product product, Payment payment)
        {
            _paymentRepository.Insert(payment);
            _productRepository.Insert(product);
        }
    }
}