using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Decorator
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            var pizza = new LargePizza();
            var cheese = new CheeseDecorator(pizza);
            var tomato = new TomatoDecorator(cheese);

            return Content($"Decorato Pattern Pizza: {tomato.GetDescription()} - {tomato.CalculateCost()}");
        }
    }
}