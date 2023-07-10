using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    public class LogisticSubject
    {
        private readonly List<ILogisticsObserver> _logisticsObservers;

        public LogisticSubject()
        {
            _logisticsObservers = new List<ILogisticsObserver>();
        }

        public void Attach(ILogisticsObserver observer)
        {
            _logisticsObservers.Add(observer);
            PrintObserversCount();
        }

        public void Detach(ILogisticsObserver observer)
        {
            _logisticsObservers.Remove(observer);
            PrintObserversCount();
        }

        private void PrintObserversCount()
        {
            switch(_logisticsObservers.Count)
            {
                case < 1:
                    Console.WriteLine("There are no observers.");
                    break;
                case 1:
                    Console.WriteLine("These is 1 observer");
                    break;
                default:
                    Console.WriteLine("There are " + _logisticsObservers.Count + " observers");
                    break;
            }
        }

        public void NotifyAvailable()
        {
            foreach(var observer in _logisticsObservers)
            {
                observer.SchedulePickup();
            }
        }
    }
}
