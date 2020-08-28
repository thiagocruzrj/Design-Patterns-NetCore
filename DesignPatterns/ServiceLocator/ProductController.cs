using DesignPatterns.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.ServiceLocator
{
    public sealed class ProductController : Controller
    {
        private IProductRepository ProductRepository
        {
            get
            {
                return DependencyResolver.Current.GetService<IProductRepository>();
            }
        }

        public IActionResult Index()
        {
            var product = new Product()
            {
                Id = 1,
                Name = "product 1"
            };

            ProductRepository.Insert(product);

            return Content("Service Locator Pattern");
        }
    }
}