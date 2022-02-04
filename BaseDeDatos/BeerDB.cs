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

        public Beer get(int id)
        {
            Connect();
            Beer beer = null;
            string query = "SELECT Name, BrandID from beer where id = @id";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                string Name = reader.GetString(0);
                int idbrand = reader.GetInt32(1);

                beer = new Beer(id, Name, idbrand);
            }

            Close();

            return beer;
        }

        public void Edit(Beer b)
        {
            Connect();

            string query = "UPDATE BEER SET Name = @Name, BrandID = @BrandId where id = @id";
            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.AddWithValue("@id", b.Id);
            command.Parameters.AddWithValue("@Name", b.Name);
            command.Parameters.AddWithValue("@BrandId", b.BrandId);

            command.ExecuteNonQuery();

            Close();
        }

        public void Add(Beer b)
        {
            Connect();

            string query = "INSERT INTO Beer(Name,BrandID) " +
                "VALUES (@Name,@brandId)";

            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@Name", b.Name);
            command.Parameters.AddWithValue("@brandId", b.BrandId);
            
            command.ExecuteNonQuery();

            Close();
        }

        public void Delete(int id)
        {
            Connect();

            string query = "delete from beer where id = @id";

            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();

            Close();
        }

      
    }
}
