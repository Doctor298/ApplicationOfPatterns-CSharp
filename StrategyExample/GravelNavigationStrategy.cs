using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample
{
    public class GravelNavigationStrategy : INavigationStrategy
    {
        public INavigationRoute FindRoute(string parameters)
        {
            return new NavigationRoute
            {
                RouteDetails = "I'm a gravel road"
            };
        }
    }
}
