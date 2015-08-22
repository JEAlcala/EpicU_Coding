using DataFromSQLChallenge.service.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFromSQLChallenge.service
{
    public class OrderService
    {
        String _connectionString;
        public OrderService(string connectionString)
        {
            _connectionString = connectionString;       
        }
        public OrderService

        public List<Customers> GetCustomersByState(string state)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(@"
                Select * from Customers Where State = @state 
                ",conn);
                
                cmd.Parameters.Add("@state",SqlDbType.NVarChar, 50).Value = state;
                using (var rd = cmd.ExecuteReader())
                {
                    while(rd.Read())
                    {
                        var c = new Customers {
                            CustomerID = (int)rd["CustomerID"],
                            FirstName = (string)rd["FirstName"],
                            LastName = (string)rd["LastName"],
                            Address = (string)rd["Address"]
                        });
                    }
                }

            }
        }
    }
}
