using MongoDB.Bson;
using System;
using System.Collections.Generic;
using TDD.Examples.MoqDatabase;

namespace TDD.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            Random rand = new Random();

            var get = order.FindOne(114519930);
            var obj = get.DynamicObj["types"];

            var dict = new Dictionary<string, object>();
            dict.Add("target", 1);
            dict.Add("jeff", "3");
            dict.Add("types", new List<string> { "a", "b" });


            order.Save(new OrderModel { Number = rand.Next(), Text = "Test", Type = "Box", DynamicObj = dict });
        }
    }
}
