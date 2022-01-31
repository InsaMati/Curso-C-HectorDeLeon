using System.Text.Json;

Beer myBeer = new Beer()
{
    Name = "Pikantus",
    Brand = "Erdinger"
};

// Formato JSON

//Serializar
string json = JsonSerializer.Serialize(myBeer);

//Descealizacion
Beer beer = JsonSerializer.Deserialize<Beer>(json);

//string json = "{\"Name\": \"Pikantus\", \"Brand\": \"Erdinger\"}";

Beer[] beers = new Beer[]
{
    new Beer()
    {
        Name = "Pikantus",
        Brand = "Erdinger"
    },

    new Beer()
    {
        Name = "Corona",
        Brand = "Modelo"
    }

};

//string json2 = "[" + "{\"Name\":\"pikantus\",\"Brand\": \"Erdinger\"}," +
//    "{\"Name\":\"Corona\",\"Brand\": \"Modelo\"}" +
//    "]";

string json2 = JsonSerializer.Serialize(beers);
Beer[] beers2 = JsonSerializer.Deserialize<Beer[]>(json2);

public class Beer
{
    public string Name { get; set; }
    public string Brand { get; set; }
}