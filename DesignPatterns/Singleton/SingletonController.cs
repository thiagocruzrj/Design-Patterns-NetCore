using Microsoft.AspNetCore.Mvc;
using System;

namespace DesignPatterns.Singleton
{
    public sealed class SingletonController : Controller
    {
        public IActionResult Index()
        {
            Log.Instance.LogException(new Exception("test"));

            return Content("Singleton");
        }
    }
}