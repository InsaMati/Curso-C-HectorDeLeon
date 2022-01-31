/*int i = 0;

while (i < 10) 
{
    Console.WriteLine("Iteracion de i: " + i);
    i++;
}

int j = 0;

while (j < 100) {


    // Rompemos el ciclo del while.

    if (j > 10)
        break;

    Console.WriteLine(j);
    j++;
}*/

string[] friends = new string[6]
{
    "Pancho",
    "Paco",
    "Ana",
    "Ruben",
    "Karla",
    "Luis",
};

int index = 0;

while (index < friends.Length) {

    Console.WriteLine(friends[index++]);

};


bool run = false;

do
{
    Show();
}
while (run);

static void Show()
{
    Console.WriteLine("Entro una vez y ya");
}