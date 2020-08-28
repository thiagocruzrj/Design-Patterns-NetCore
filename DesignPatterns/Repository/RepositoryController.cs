using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Repository
{
    public class RepositoryController : Controller
    {
        readonly IProductRepository _productRepository;

        public RepositoryController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var product = new Product()
            {
                Id = 200,
                Name = "Product 200"
            };

            _productRepository.Insert(product);

            return Content("Repository Pattern");
        }
    }
}