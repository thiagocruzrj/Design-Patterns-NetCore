using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DesignPatterns.Factory
{
    public class FactoryController : Controller
    {
        public IActionResult Index()
        {
            var types = new List<string>() { "Car", "Bus", "Truck" };
            var transports = new List<ITransport>();
            types.ForEach(x => transports.Add(FactoryTransport.CreateInstance(x)));

            foreach (var transport in transports)
            {
                var result = transport.Build();
            }

            return Content("Facotory used");
        }
    }
}