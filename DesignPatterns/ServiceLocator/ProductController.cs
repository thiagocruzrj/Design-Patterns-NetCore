using DesignPatterns.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.ServiceLocator
{
    public class ProductController : Controller
    {
        private IProductRepository ProductRepository
        {
            get
            {
                return DependencyResolver.Current
            }
        }
    }
}