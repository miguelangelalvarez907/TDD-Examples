using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TDD.Examples.MoqDatabase
{
    public class OrderModel : IOrderModel
    {
        public OrderModel()
        {
            DateCreated = DateTime.Now;
        }
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        public string Text { get; set; }
        public int Number { get; set; }
        public string Type { get; set; }
        public DateTime DateCreated { get; set; }
        public Dictionary<string, object> DynamicObj { get; set; }
    }

    public interface IOrderModel
    {
         string Text { get;}
         int Number { get; }
    }
}
