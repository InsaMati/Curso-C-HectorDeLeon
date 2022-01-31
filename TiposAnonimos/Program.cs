// Objetos Anonimos

// Es ReadOnly

var hector = new
{
    Name = "Hector",
    Country = "Mexico"
};

//Console.WriteLine($"{hector.Name} {hector.Country}");

// Todos los elementos deben tener la misma estructura.
var beers = new[]
{
    new{ Name = "Red", Brand = "Delirium"},
    new{ Name ="Londo Porter", Brand = "Fullers"}
};

foreach (var b in beers)
{
    Console.WriteLine($"Cerveza {b.Name} {b.Brand}");
}

