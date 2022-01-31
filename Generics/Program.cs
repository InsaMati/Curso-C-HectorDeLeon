// GENERICS

MyList<int> lista = new MyList<int>(10);
lista.Add(10);
lista.Add(6);

MyList<string> strings = new MyList<string>(10);
strings.Add("Matias");

/*Console.WriteLine(lista.GetElement(11));
Console.WriteLine(strings.GetElement(0));

Console.WriteLine(lista.GetString());
Console.WriteLine(strings.GetString());*/

MyList<People> people = new MyList<People>(5);

people.Add(new People() { Name = "Matias", Country = "Argentina" });
people.Add(new People() { Name = "Hector", Country = "Mexico" });

Console.WriteLine(people.GetString());

public class People 
{
    public string? Name { get; set; }
    public string? Country { get; set; }

    public override string ToString()
    {
        return $"Nombre: {Name}, Pais: {Country}";
    }


}

public class MyList<T>
{
    private T[] _elements;
    private int _index;

    public MyList(int n)
    {
        _elements = new T[n];
    }

    public void Add(T e)
    {
        if(_index < _elements.Length) 
        {
            _elements[_index] = e;
            _index++;
        }
    }

    public T GetElement(int i) 
    {
        if(i <= _index && i >=0)
        {
            return _elements[i];
        }

        return default(T);
    }

    public string GetString()
    {
        int i = 0;
        string result = "";

        while(i < _index) 
        {
            result += _elements[i].ToString() + "|";
            i++;
        }

        return result;
    }

}