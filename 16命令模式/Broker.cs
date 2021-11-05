using System;
using System.Collections.Generic;
using System.Text;

namespace _16命令模式
{
    public class Broker
    {
        private List<IOrder> orders = new List<IOrder>();

        public void TakeOrder(IOrder order)
        {
            orders.Add(order);
        }

        public void PlaceOrders()
        {
            foreach(var order in orders)
            {
                order.Excute();
            }
            orders.Clear();
        }
    }
}
