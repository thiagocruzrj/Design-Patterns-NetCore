using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Composite
{
    public sealed class CompositeController : Controller
    {
        public IActionResult Index()
        {
            var nodes = new Controls() { Id = 1 };
            nodes.Add(new Control() { Id = 2 });
            nodes.Add(new Control() { Id = 3 });
            IControl control = nodes;

            return Content($"Composite:</br> {control.Render()}");
        }
    }
}