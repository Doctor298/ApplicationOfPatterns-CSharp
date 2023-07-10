using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample
{
    public class RoadNavigationStrategy : INavigationStrategy
    {
        public INavigationRoute FindRoute(string parameters)
        {
            // This is where the algorithm goes.
            return new NavigationRoute
            {
                RouteDetails = "I'm a road route"
            };
        }
    }
}
