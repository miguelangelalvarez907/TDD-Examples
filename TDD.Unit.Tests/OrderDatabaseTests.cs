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
        private OrderService _orderService;

        [SetUp]
        public void Setup()
        {
            _orderDatabase = new Mock<IOrder>();
        } 


        [TestCase(1, "OK")]
        [TestCase(2, "OK")]
        [TestCase(550, "NO")]
        public void Check_order_number_with_a_OK_response(int orderNumber, string expectedResult)
        {     
            // arrange
            _orderDatabase.Setup(p => p.FindOne(orderNumber))
                .Returns(new OrderModel { Number = orderNumber, Text = "Test", DateCreated = DateTime.Now, Type = "Box" });

            _orderService = new OrderService(_orderDatabase.Object);

            // action
            var result = _orderService.ProcessOrder(orderNumber);

            // assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(1,"test", "OK")]
        [TestCase(1, "bob", "NO")]
        public void Check_order_number_using_a_model_as_param(int orderNumber,string text, string expectedResult)
        {
            // arrange
            var _orderModel = Mock.Of<OrderModel>(x => x.Text == text && x.Number == orderNumber);

            _orderDatabase.Setup(p => p.FindOne(_orderModel))
                .Returns(new OrderModel { Number = orderNumber, Text = text, DateCreated = DateTime.Now, Type = "Box" });
            // action
            _orderService = new OrderService(_orderDatabase.Object);
            var result = _orderService.ProcessOrder(_orderModel);

            //assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
