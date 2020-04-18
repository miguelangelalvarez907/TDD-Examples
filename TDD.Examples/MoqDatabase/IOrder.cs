using System.Threading.Tasks;

namespace TDD.Examples.MoqDatabase
{
    public interface IOrder
    {
        bool Save(OrderModel value);

        OrderModel FindOne(int orderNumber);

        OrderModel FindOne(OrderModel orderModel);
    }
}
