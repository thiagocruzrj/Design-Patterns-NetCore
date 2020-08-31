using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Adapter
{
    public sealed class AdapterController : Controller
    {
        public IActionResult Index()
        {
            var square = new Square() { Side = 30 };
            var calc = new CalcAdapter();
            var area = calc.CalculateArea(square);

            return Content($"ADAPTER PATTERN RESULT area {square.Side}: {area}");
        }
    }
}