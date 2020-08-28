using DesignPatterns.Repository;

namespace DesignPatterns.LazyLoading
{
    public class ProductService
    {
        private IProductRepository _productRepository;
        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = DependencyResolver.Current.GetService<IProductRepository>();
                return _productRepository;
            }
        }
    }
}