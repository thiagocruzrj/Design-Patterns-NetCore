using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Strategy
{
    public class DescendingSortStrategy : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            list = list.OrderByDescending(x => x).ToList();
        }
    }
}