Beer myBeer = new Beer()
{
    Name = "Pikantus",
    Brand = "Erdinger"
};

// Formato JSON

string json = "{\"Name\": \"Pikantus\", \"Brand\": \"Erdinger\"}";

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

string json2 = "[" + "{\"Name\":\"pikantus\",\"Brand\": \"Erdinger\"}," +
    "{\"Name\":\"Corona\",\"Brand\": \"Modelo\"}" +
    "]";


public class Beer
{
    public string Name { get; set; }
    public string Brand { get; set; }
}