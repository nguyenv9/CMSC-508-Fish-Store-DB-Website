using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace FishStore.Models
{
    public class DatabaseContext
    {
        public string ConnectionString { get; set; }
        public DatabaseContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<string> GetProduct()
        {
            List<string> output = new List<string>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT ProductName FROM Product", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        output.Add(reader["ProductName"].ToString());
                    }
                }
            }
            return output;
        }
        public void InsertProduct(/*string a, string b, string c, double x, string d, int y*/)
        {
            List<string> output = new List<string>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Product VALUES (NULL, \"LiveFish\", \"Cory Catfish\", \"catfish.jpg\", 4.99, \"Beginner Fish\", 2);", conn);
                cmd.ExecuteNonQuery();

            }
            
        }
    }
}
