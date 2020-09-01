using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Strategy
{
    public class AscendingSortStrategy : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            list = list.OrderBy(x => x).ToList();
        }
    }
}