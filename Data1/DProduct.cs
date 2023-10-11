using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entety2;

namespace Data1
{
    public class DProduct
    {
        private readonly string connectionString = "Data Source=LAB1504-28\\SQLEXPRESS;Initial Catalog=FacturaDB;User ID=admin;Password=admin";

        public List<Product> Get()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("listarProductos", connection))
                {
                    command.CommandType = CommandType.StoredProcedure; 

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                name = reader["Name"].ToString(),
                                price = (decimal)reader["Price"],
                                stock = (int)reader["Stock"],
                                active = (bool)reader["Active"]
                            };
                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }
    }
}
