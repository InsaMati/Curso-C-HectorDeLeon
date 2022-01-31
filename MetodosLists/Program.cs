List<int> vs = new List<int>() 
{
    4,3,5,19
};

Show(vs);

// Podes elegir la posicion
vs.Insert(0,6);

// Contains
if (vs.Contains(19))
    Console.WriteLine("Existe");
else
    Console.WriteLine("No Existe");

// IndexOf
int pos = vs.IndexOf(19);
Console.WriteLine(pos);

pos = vs.IndexOf(100);
Console.WriteLine(pos);

// Sort

vs.Sort();
Show(vs);

// Add Range

vs.AddRange(new List<int>()
{
    200,300,400
});

Show(vs);

static void Show(List<int> numbers)
{
    Console.WriteLine("-- Numeros -- ");

    foreach (int i in numbers)
    {
        Console.WriteLine(i);
    }
}
