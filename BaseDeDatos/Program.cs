using BaseDeDatos;
using System.Data.SqlClient;

try
{
    BeerDB db = new BeerDB(@"DESKTOP-0GQUGO5\SQLEXPRESS", "CsharpDB");

    List<Beer> beers = db.GetAll();

    foreach (Beer beer in beers)
    {
        Console.WriteLine($"ID: {beer.Id}, Nombre: {beer.Name}, Marca: {beer.BrandId}");
    }
 
}
catch (SqlException ex)
{
    Console.WriteLine(ex.Message);
}