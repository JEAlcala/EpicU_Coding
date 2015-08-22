
using EpicVitaminSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpicVitamins
{
    public class OrderService
    {
        EpicVitaminsDb _db = new EpicVitaminsDb();

        public int CommitOrder(EpicVitaminSample.Models.Order order)
        {
            using (var db = new EpicVitaminsDb())
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return order.OrderID;
            }
        }

        public Order GetOrder(int orderID)
        {
            return _db.Orders.Find(orderID);
        }
    }
}