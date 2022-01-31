//var Numbers = new List<int>()

List<int> Numbers = new List<int>()
{
    23,3,5,10,22,12
};

foreach(int num in Numbers)
{
    Console.WriteLine(num);
}

var students = new List<People>()
{
    new People(){ Name = "Matias", Country = "Argentina"},
    new People(){ Name = "Agustin", Country = "Argentina"},
    new People(){ Name = "Jorge", Country = "Paraguay"}
};


Show(students);

students.RemoveAt(0);

Show(students);


static void Show(List<People> students)
{
    Console.WriteLine("-- Personas -- ");

    foreach(People student in students)
    {
        Console.WriteLine($"Nombre: {student.Name},Pais: {student.Country}");
    }
        
}

public class People
{
    public string Name { get; set; }
    public string Country { get; set; }
}



