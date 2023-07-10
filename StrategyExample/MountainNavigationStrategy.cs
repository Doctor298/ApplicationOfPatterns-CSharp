using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample
{
    public class MountainNavigationStrategy : INavigationStrategy
    {
        public INavigationRoute FindRoute(string parameters)
        {
            return new NavigationRoute
            {
                RouteDetails = "I'm a mountain road"
            };
        }
    }
}
