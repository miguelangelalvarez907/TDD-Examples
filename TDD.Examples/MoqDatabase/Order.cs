using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace TDD.Examples.MoqDatabase
{
    public class Order : IOrder
    {
        private readonly IMongoDatabase _mongoDatabase;
        private readonly IMongoCollection<OrderModel> _collection;

        public Order()
        {
            var mongoClient = new MongoClient("mongodb://localhost:27017/");
            _mongoDatabase = mongoClient.GetDatabase("order");
            _collection = _mongoDatabase.GetCollection<OrderModel>("order_collection");

#pragma warning disable CS0618 // Type or member is obsolete
            _collection.Indexes.CreateOne(Builders<OrderModel>.IndexKeys.Descending(x => x.Number), new CreateIndexOptions { Unique = true});
#pragma warning restore CS0618 // Type or member is obsolete
        }

        public OrderModel FindOne(int orderNumber)
        {
            return _collection.Find(x => x.Number == orderNumber).First();
        }

        public OrderModel FindOne(OrderModel orderModel)
        {
            return _collection.Find(x => x.Number == orderModel.Number && x.Text == orderModel.Text).First();
        }

        public bool Save(OrderModel value)
        {
            try
            {
                _collection.InsertOne(value);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
