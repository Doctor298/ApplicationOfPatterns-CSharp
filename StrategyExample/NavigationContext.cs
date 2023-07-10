using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample
{
    public class NavigationContext 
    {
        public INavigationStrategy NavigationStrategy { get; set; }

        public NavigationContext()
        {
            // Default
            NavigationStrategy = new RoadNavigationStrategy();
        }

        public void StartNavigation()
        {
            var route = NavigationStrategy.FindRoute("parameters go here");
            Console.WriteLine(route.RouteDetails);
        }
    }
}
