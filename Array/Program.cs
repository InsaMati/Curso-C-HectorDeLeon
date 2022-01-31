string[] friends = new string[7]
{
    "Hector",
    "Matias",
    "Evelin",
    "Jorge",
    "Silvia",
    "Gandalf",
    null,
};

friends[6] = "Carlos";

foreach(string friend in friends)
{
    Console.WriteLine(friend);
}
