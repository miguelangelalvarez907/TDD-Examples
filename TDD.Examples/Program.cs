using System;
using TDD.Examples.MoqDatabase;

namespace TDD.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();

            order.Save(new OrderModel { Number = 1, Text = "Test", Type = "Box" });

            var get = order.FindOne(1);

        }
    }
}
