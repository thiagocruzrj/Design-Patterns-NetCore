using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Proxy
{
    public class ProxyController : Controller
    {
        public IActionResult Index(int id = 16)
        {
            var user = new User() { Age = id };
            var proxy = new CalcProxy(user);
            var result = proxy.Calculate();
            var message = proxy.Message;

            return Content($"result from Proxy: {result} of age {id}: {message}");
        }
    }
}