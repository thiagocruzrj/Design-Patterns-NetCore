namespace RepositoryPattern
{
    public class RepositoryController
    {
        readonly IProductRepository _productRepository;

        public RepositoryController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ActionResult Index()
        {
            var product = new Product();
            _productRepository.Insert(product);

            return View();
        }
    }
}