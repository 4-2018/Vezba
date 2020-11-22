using PresentationLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
    public class ResaurantRepository
    {
        public List<Restaurant> GetAllMenuItems ()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            using (SqlConnection conn = new SqlConnection(Constants.connString))
            {
                conn.Open();

                SqlCommand comm = new SqlCommand
                {
                    Connection = conn,

                    CommandText = "SELECT * FROM MenuItems"
                };

                SqlDataReader reader = comm.ExecuteReader();

                while(reader.Read())
                {
                    Restaurant r = new Restaurant(reader.GetInt32(0), reader.GetString(1),
                        reader.GetString(2), reader.GetDecimal(3));

                    restaurants.Add(r);
                }
            }
            return restaurants;
        }

        public int InsertMenuItems(Restaurant r) 
        {
            using(SqlConnection conn = new SqlConnection(Constants.connString))
            {
                conn.Open();

                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;

                comm.CommandText = String.Format("INSERT INTO dbo.MenuItems (Title, Description, Price) " +
                    "VALUES ('{0}', '{1}', {2});", r.Title, r.Description, r.Price);

                int result = comm.ExecuteNonQuery();

                return result;
            }
        }
    }
}
