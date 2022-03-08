using BaseDeDatos;
using System.Data.SqlClient;

try
{
    BeerDB db = new BeerDB(@"DESKTOP-0GQUGO5\SQLEXPRESS", "CsharpDB");

    bool again = true;
    int op = 0;

    do
    {
        ShowMenu();

        Console.WriteLine("Elige una opcion: ");
        op = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case 1:
                Show(db);
                break;
            case 2:
                Add(db);
                break;
            case 3:
                Edit(db);
                break;
            case 4:
                Delete(db);
                break;
            case 5:
                again = false;
                break;

        };

    } while (again);
        
 
}
catch (SqlException ex)
{
    Console.WriteLine(ex.Message);
}

static void ShowMenu()
{
    Console.WriteLine("\n-------Menu------");
    Console.WriteLine("1.- Mostrar");
    Console.WriteLine("2.- Agregar");
    Console.WriteLine("3.- Editar");
    Console.WriteLine("4.- Eliminar");
    Console.WriteLine("5.- Salir");
}

static void Show(BeerDB db)
{
    Console.Clear();

    Console.WriteLine("Cervezas de la base de datos");

    List<Beer> beers = db.GetAll();

    foreach (Beer beer in beers)
    {
        Console.WriteLine($"ID: {beer.Id}, Nombre: {beer.Name}, Marca: {beer.BrandId}");
    }
}

static void Add(BeerDB beerDB)
{
    Console.Clear();

    Console.WriteLine("Agregar nueva cerveza");

    Console.WriteLine("Escribe el nombre de la cerveza: ");
    string name = Console.ReadLine();

    Console.WriteLine("Escribe el ID de la marca: ");
    int id = Convert.ToInt32(Console.ReadLine());

    beerDB.Add(new Beer(name, id));
}


static void Edit(BeerDB beerDB)
{
    Console.Clear();

    Show(beerDB);

    Console.WriteLine("Editar cerveza");
    Console.WriteLine("Escribe el ID de tu cerveza a editar: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Beer beer = beerDB.get(id);
    if(beer!=null)
    {
        Console.WriteLine("Escribe el nombre: ");
        string name = Console.ReadLine();

        Console.WriteLine("Escriba el ID: ");
        int idmod = Convert.ToInt32(Console.ReadLine());

        beerDB.Edit(new Beer(id,name, idmod));
    }
    else
    {
        Console.WriteLine("La cerveza no existe.");
    }

}

static void Delete(BeerDB beerDB)
{
    Console.Clear();

    Show(beerDB);

    Console.WriteLine("Eliminar cerveza");

    Console.WriteLine("Id de cerveza a eliminar: ");
    int idelm = Convert.ToInt32(Console.ReadLine());

    Beer beer = beerDB.get(idelm);

    if(beer != null)
    {
        beerDB.Delete(idelm);
    }
    else
    {
        Console.WriteLine("La cerveza no existe.");
    }



}