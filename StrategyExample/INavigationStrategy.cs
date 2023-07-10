using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample
{
    public interface INavigationStrategy
    {
        public INavigationRoute FindRoute(string parameters);
    }
}
