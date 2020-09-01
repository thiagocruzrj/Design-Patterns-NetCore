using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public class Strategy
    {
        private readonly ISortStrategy _strategy;

        public Strategy(ISortStrategy strategy)
        {
            _strategy = strategy;
        }

        public List<string> Sort(List<string> list)
        {
            _strategy.Sort(list);

            return list;
        }
    }
}