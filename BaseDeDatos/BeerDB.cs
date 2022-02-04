using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    public class BeerDB : DB
    {
        public BeerDB(string server, string db) : base(server, db)
        {

        }

        public List<Beer> GetAll()
        {
            
            Connect();
            List<Beer> beers = new List<Beer>();
            string query = "SELECT ID,Name,BrandID FROM BEER";
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                beers.Add(new Beer(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
            }

            Close();

            return beers;
        }
      
    }
}
