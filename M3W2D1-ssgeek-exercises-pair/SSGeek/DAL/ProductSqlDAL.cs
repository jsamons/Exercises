using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSGeek.Models;
using System.Data.SqlClient;

namespace SSGeek.DAL
{
    public class ProductSqlDAL
    {

        string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog = ssgeekshoppingcart; Integrated Security = True";
        private const string SQL_GetProducts = "select * from products";
        private const string SQL_GetProduct = "select * from products where product_id = @product_id";


        public Product GetProduct(int id)
        {
            Product product = new Product();
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetProduct, connection);
                    cmd.Parameters.AddWithValue("@product_id", id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Product p = new Product();
                        p.ProductId = Convert.ToInt32(reader["product_id"]);
                        p.Name = Convert.ToString(reader["name"]);
                        p.Description = Convert.ToString(reader["description"]);
                        p.Price = Convert.ToDouble(reader["price"]);
                        p.ImageName = Convert.ToString(reader["image_name"]);

                        product = p;
                    }
                    return product;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetProducts, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Product p = new Product();
                        p.ProductId = Convert.ToInt32(reader["product_id"]);
                        p.Name = Convert.ToString(reader["name"]);
                        p.Description = Convert.ToString(reader["description"]);
                        p.Price = Convert.ToDouble(reader["price"]);
                        p.ImageName = Convert.ToString(reader["image_name"]);

                        products.Add(p);
                    }

                    return products;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}