using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample
{
    public class OrdersCollection : IteratorAggregate
    {
        public List<BicycleOrder> Orders { get; set; }

        public OrdersCollection()
        {
            Orders = new List<BicycleOrder>();
        }

        public void AddOrder(BicycleOrder order)
        {
            Orders.Add(order);
        }

        public override IEnumerator GetEnumerator()
        {
            return new PaintOrderIterator(this);
        }
    }
}
