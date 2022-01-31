// TIBURONES

Shark[] sharks = new Shark[]
{
    new Shark("Tiburoncin",56),
    new Shark("Jaws",65)

};

ShowFish(sharks);
ShowAnimals(sharks);

// SIRENAS
// IFish[] fish = new Siren[]

IFish[] fishs = new IFish[]
{
    new Siren(100),
    new Shark("Tiburoncin",56),
};

ShowFish(fishs);

//IFish F = new Shark("Tiburon", 40);
//F.NAME ???

static void ShowAnimals(IAnimal[] animals)
{
    Console.WriteLine("-Mostramos los animales --");
    int i = 0;

    while (i < animals.Length)
    {
        Console.WriteLine(animals[i].Name);
        i++;
    }
}

static void ShowFish(IFish[] fishs)
{
    Console.WriteLine("-Mostramos los peces --");
    int i = 0;

    while(i<fishs.Length)
    {
        Console.WriteLine(fishs[i].Swim());
        i++;
    }
}

public class Siren : IFish 
{
    public int Speed { get; set; } 
    public Siren(int Speed) 
    {
        this.Speed = Speed;  
    }
    public string Swim() 
    {
        return $"La sirena nada a {Speed}"; 
    }
}
public class Shark : IAnimal, IFish
{
    public string Name { get; set; }
    public int Speed { get; set; }

    public Shark(string Name,int Speed)
    {
        this.Name = Name;
        this.Speed = Speed; 
    }

    public string Swim()
    {
        return $"{Name} Nada {Speed} km/";
    
    }

}

public interface IAnimal 
{
    public string Name { get; set; }
}

public interface IFish
{ 
    public int Speed { get; set; }
    public string Swim();

}