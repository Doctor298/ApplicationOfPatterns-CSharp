using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    public class ExFedObserver : ILogisticsObserver
    {
        public void SchedulePickup()
        {
            Console.WriteLine("ExFed has been notified that a shipment is ready for pickup");
        }
    }
}
