using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public class StrategyController : Controller
    {
        public IActionResult Index()
        {
            var list = new List<string>() { "thiago", "isabella", "suzi" };

            var sort = new Strategy(new DescendingSortStrategy());
            sort.Sort(list);
            var sortAs = new Strategy(new AscendingSortStrategy());
            sortAs.Sort(list);
            var sortBu = new Strategy(new BubbleSortStrategy());
            sortBu.Sort(list);

            return Content("Strategy");
        }
    }
}