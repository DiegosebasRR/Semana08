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
        private readonly string connectionString = "Data Source=DESKTOP-0OKTP7C\\MSSQLSERVERRR;Initial Catalog=FacturaDB;User ID=admin;Password=admin";

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

        public void Delete(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("eliminarProducto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@name", name);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(Product product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("actualizarProducto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@name", product.name);
                    command.Parameters.AddWithValue("@price", product.price);
                    command.Parameters.AddWithValue("@stock", product.stock);
                    command.Parameters.AddWithValue("@active", product.active);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
