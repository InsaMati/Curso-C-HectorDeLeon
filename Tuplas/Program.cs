// Tuplas

//Esto es una TUPLA

(int id, string name) product = (1, "Cerveza stout");

Console.WriteLine($"{product.id} {product.name}");

// A diferencia de los tipos ANONIMOS
// las tuplas si se pueden modificar/editar

product.name = "Cerveza porter";

Console.WriteLine($"{product.id} {product.name}");

// Tupla SpeedRun
var person = (1, "Hector");
Console.WriteLine($"Persona {person.Item1} {person.Item2}");

// Arreglos en tuplas
var people = new[]
{
    (1,"Hector"),
    (2,"Pedro"),
    (3,"Juan")
};

foreach (var p in people)
{
    Console.WriteLine($"Persona {p.Item1} {p.Item2}");
}

(int id, string name)[] people2 = new[]
{
    (1,"Hector"),
    (2,"Pedro"),
    (3,"Juan")
};

foreach (var p in people2)
{
    Console.WriteLine($"Persona {p.id} {p.name}");
}

var cityinfo = getLocationCDMX();
Console.WriteLine($"Lat: {cityinfo.lat} Long: {cityinfo.lon} Name: {cityinfo.name}");

var (_, lon, _) = getLocationCDMX();
Console.WriteLine(lon);

static (float lat,float lon,string name) getLocationCDMX()
{
    float lat = 19f;
    float lon = -99.19f;
    string name = "CDMX";

    return (lat,lon,name);
}