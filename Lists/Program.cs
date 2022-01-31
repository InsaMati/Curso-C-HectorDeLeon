using System.Collections.Generic;

List<int> numbers = new List<int>();

numbers.Add(5);
numbers.Add(2);

Console.WriteLine(numbers.Count);


List<int> numbers2 = new List<int>()
{
    5,2,3,4,10
};

Console.WriteLine(numbers2.Count);

numbers2.Add(55);

Console.WriteLine(numbers2.Count);

numbers2.Clear();
Console.WriteLine(numbers2.Count);

List<string> countries = new List<string>()
{
    "Mexico","Argentina","España"
};

Console.WriteLine(countries.Count);