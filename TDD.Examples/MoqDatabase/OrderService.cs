using System;
using System.Collections.Generic;
using System.Text;

namespace TDD.Examples.MoqDatabase
{
    public class OrderService
    {
        private IOrder _order;

        public OrderService(IOrder order)
        {
            _order = order;
        }

        public string ProcessOrder(int orderNumber)
        {
            var getOrder = _order.FindOne(orderNumber);

            if (getOrder.Number <= 5)
            {
                return "OK";
            }

            return "NO";
        }
    }
}
