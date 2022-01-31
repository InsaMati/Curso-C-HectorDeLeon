People persona = new People()
{
    Name = "Matias",
    Age = 25
};

People Juan = new People();

Console.WriteLine(People.GetCount());

public static class A
{
    // Si hago uan clase static, todo tiene que ser estatico.
    public static void Some() {
        Console.WriteLine("Algo");
    
    }

}
public class People
{
    public static int Count = 0;
    public string? Name { get; set; }
    public int Age { get; set; }

    public People() {

        Count++;

    }

    public static string GetCount() {
        return $"Esta clase se ha utilizado {Count} veces";
    }
}