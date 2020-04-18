using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TDD.Examples.CodeExamples;
using Moq;
using TDD.Examples.MoqExamples;
using TDD.Examples.MoqDatabase;

namespace TDD.Unit.Tests
{
    [TestFixture]
    class OrderDatabaseTests
    {
        private Mock<IOrder> _orderDatabase;
        //private Mock<OrderModel> _orderModel;
        private OrderService _orderService;

        [TestCase(1, "OK")]
        [TestCase(2, "OK")]
        [TestCase(550, "NO")]
        public void Check_order_number_with_a_OK_response(int orderNumber, string expectedResult)
        {
            _orderDatabase = new Mock<IOrder>();

            //_orderModel = new Mock<OrderModel>();
            //_orderModel.Setup(s => s.Number).Returns(orderNumber);
            //_orderModel.SetupAllProperties();

            _orderDatabase.Setup(p => p.FindOne(orderNumber))
                .Returns(new OrderModel { Number = orderNumber, Text = "Test", DateCreated = DateTime.Now, Type = "Box" });

            _orderService = new OrderService(_orderDatabase.Object);

            var result = _orderService.ProcessOrder(orderNumber);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
