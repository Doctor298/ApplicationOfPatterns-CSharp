using BumbleBikesLibrary.PaintableBicycle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample
{
    public class PaintOrderIterator : Iterator
    {
        private readonly OrdersCollection _orders;

        private int _position;

        public PaintOrderIterator(OrdersCollection orders)
        {
            _orders = SeparateCustomPaintJobOrders(orders);
            _position = -1;
        }

        public override int Key()
        {
            return _position;
        }

        public override bool MoveNext()
        {
            var updatedPosition = _position + 1;

            if (updatedPosition < 0 || updatedPosition >= _orders.Orders.Count)
                return false;
            _position = updatedPosition;
            return true;
        }

        public override void Reset()
        {
            _position = 0;
        }

        public override object Current()
        {
            return _orders.Orders[_position];
        }

        private OrdersCollection SeparateCustomPaintJobOrders(OrdersCollection orders)
        {
            var customPaintJobOrders = new List<BicycleOrder>();
            var standardPaintJobOrders = new List<BicycleOrder>();

            foreach (var order in orders.Orders)
            {
                var paintJob = order.Bicycle.PaintJob;

                bool isCustom = paintJob.GetType().IsSubclassOf(typeof(CustomGradientPaintJob));

                if(isCustom)
                {
                    customPaintJobOrders.Add(order);
                }
                else
                {
                    standardPaintJobOrders.Add(order);
                }
            }

            orders.Orders.Clear();
            orders.Orders.AddRange(standardPaintJobOrders);
            orders.Orders.AddRange(customPaintJobOrders);

            return orders;
        }
    }
}
