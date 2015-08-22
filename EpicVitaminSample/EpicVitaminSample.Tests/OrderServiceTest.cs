using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpicVitaminSample.Models;

namespace EpicVitaminSample.Tests
{
    [TestClass]
    public class OrderServiceTest
    {
        [TestMethod]
        public void CommitOrderTest()
        {
            //Arrange
            //--> Intantiate new Order Object 
            var order = new Order
            {
                FirstName = "David",
                LastName = "Thompson",
                Address = "123 SomeStreet",
                City = "Dallas",
                State = "TX",
                Zip = "75220";

                OrderDetails = new List<OrderDetail>
                {
                    new OrderDetail {ItemCode="abcd", Description="Cool Item", PriceEach=1.2M, Quantity=1M, Total=1.2M}
                }


            };
            var svc = new EpicVitamins.OrderService();
            
            //Act
            var orderID = svc.CommitOrder(order);
            
            //Assert
            var checkOrder = svc.GetOrder(orderID);

            Assert.AreEqual(order.FirstName, checkOrder.FirstName, "FirstName");
            Assert.AreEqual("abcd", checkOrder.OrderDetails.First().ItemCode);
        }
    }
}
