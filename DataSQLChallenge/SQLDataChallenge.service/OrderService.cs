using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDataChallenge.service
{
    public class OrderService
    {
        string _connectionString;
        public OrderService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public OrderService()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["ACME"].ConnectionString;
        }

        public void CreateOrder(int customerID, decimal orderTotal, string itemCode)
        {

        }

        public void UpdateOrderDate(int orderID, DateTime newOrderDate)
        {
            //new

            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("Your update statement", conn);
                //don't forget about parameters
                cmd.ExecuteNonQuery();
            }
        }
    }
}
