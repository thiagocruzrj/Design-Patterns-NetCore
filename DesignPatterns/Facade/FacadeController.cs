using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Facade
{
    public sealed class FacadeController : Controller
    {
        public IActionResult Index()
        {
            var facade = new Facade();
            var result = facade.Pay("3232", 45.330);

            return Content("With facade");
        }
    }
}