
List<Beer> beers = new List<Beer>()
{
        new Beer ()
        {
            Name = "Corona", Country = "Mexico"
        },

        new Beer()
        {
            Name = "Delirium", Country = "Belgica"
        },
        
        new Beer()
        {
            Name = "Erdinger" , Country = "Alemania"
        }

};

foreach (var beer in beers)
{
    Console.WriteLine(beer);
}

Console.WriteLine("----------------");

// Select 

var beersName = from b in beers
                select new
                {
                    Name = b.Name,
                    Letters = b.Name.Length
                };

foreach (var bers in beersName)
{
    Console.WriteLine($"{bers.Name} {bers.Letters}");
}

var beersNameReal = from b in beersName
                    select new
                    {
                        Name = b.Name,
                    };

Console.WriteLine("----------------");

foreach (var beerName in beersNameReal)
{
    Console.WriteLine($"Nombre: {beerName.Name}");
}

Console.WriteLine("----------------");

// Filtrar

var BeersMexico = from b in beers
                  where b.Country == "Mexico"
                  || b.Country == "Alemania"
                  select b;

foreach(var BeerMX in BeersMexico)
{
    Console.WriteLine(BeerMX);
}

Console.WriteLine("----------------");

var orderedBeers = from b in beers
                 orderby b.Country //ascending descending
                 select b;

foreach (var beer in orderedBeers)
{
    Console.WriteLine(beer);
}

public class Beer
{
    public string? Name { get; set; }
    
    public string? Country { get; set; }

    public override string ToString()
    {
        return $"Nombre: {Name}, Country: {Country}";
    }
}