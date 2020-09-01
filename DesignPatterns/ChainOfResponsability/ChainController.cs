using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.ChainOfResponsability
{
    public class ChainController : Controller
    {
        public IActionResult Index()
        {
            var seller = new Seller("Thiago", 30);
            var localManager = new Seller("Isabella", 50);
            var regionalManager = new Seller("Suzi", 70);

            seller.SetSuperior(localManager);
            localManager.SetSuperior(regionalManager);

            var result = seller.ApplyDiscount(40);
            if(result.Approved)
            {
                var mesage = $"Seller {result.SellerName} approved {result.Value}!";
            }

            return Content("Chain applied");
        }
    }
}