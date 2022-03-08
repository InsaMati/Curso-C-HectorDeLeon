using BD;
using Microsoft.EntityFrameworkCore;
using System.Linq;

DbContextOptionsBuilder<CsharpDBContext> OptionsBuilder = new DbContextOptionsBuilder<CsharpDBContext>();

OptionsBuilder.UseSqlServer("Server = DESKTOP-0GQUGO5\\SQLEXPRESS; DataBase = CsharpDB; Trusted_Connection = True;");

bool again = true;
int op = 0;

do
{
    showMenu();
    Console.WriteLine("Elegir una opcion");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Show(OptionsBuilder);
            break;
        case 2:
            Add(OptionsBuilder);
            break;
        case 3:
            Edit(OptionsBuilder);
            break;
        case 4:
            break;
        case 5:
            break;
    }



} while (again);



static void Show (DbContextOptionsBuilder<CsharpDBContext> optionBuilder)
{
    Console.Clear();
    Console.WriteLine("Cervezas en la base de datos");

    using (var context = new CsharpDBContext(optionBuilder.Options))
    {
        //List<Beer> beers = context.Beers.ToList();

        //List<Beer> beers = context.Beers.OrderBy(b => b.Name).ToList();

        List<Beer> beers = (from b in context.Beers
                            where b.BrandId == 2
                            orderby b.Name
                            select b).Include(b => b.Brand).ToList();

        foreach (var beer in beers)
        {
            Console.WriteLine($"{beer.Id} - {beer.Name} {beer.Brand.Name}");
        }
    }
}

static void Edit(DbContextOptionsBuilder<CsharpDBContext> optionBuilder)
{
    Console.Clear();
    Show(optionBuilder);
    Console.WriteLine("Editar Cerveza");
    Console.WriteLine("Escribe el ID de tu cerveza a editar: ");
    int id = int.Parse(Console.ReadLine());

    using(var context = new CsharpDBContext(optionBuilder.Options))
    {
        Beer beer = context.Beers.Find(id);

        if(beer != null)
        {
            Console.WriteLine("Escribe el nombre: ");
            string name = Console.ReadLine();

            Console.WriteLine("Escribe el ID de la marca: ");
            int brandID = int.Parse(Console.ReadLine());

            beer.Name = name;
            beer.BrandId = brandID;

            context.Entry(beer).State = EntityState.Modified;
            context.SaveChanges();
        }
        else
        {
            Console.WriteLine("Cerveza no existe");
        }
    }
}

static void Add(DbContextOptionsBuilder<CsharpDBContext> optionBuilder)
{
    Console.Clear();
    Console.WriteLine("Agregar nueva cerveza");
    Console.WriteLine("Escribe el nombre: ");
    string name = Console.ReadLine();

    Console.WriteLine("Id Marca: ");
    int brandId = int.Parse(Console.ReadLine());

    using(var context = new CsharpDBContext(optionBuilder.Options))
    {
        Beer beer = new Beer()
        {
            Name = name,
            BrandId = brandId,
        };

        context.Add(beer);

        // manda la informacion a la base de datos
        context.SaveChanges();

    }
}

static void showMenu ()
{
    Console.WriteLine("------Menu------");
    Console.WriteLine("1.- Mostrar");
    Console.WriteLine("2.- Agregar");
    Console.WriteLine("3.- Editar");
    Console.WriteLine("4.- Eliminar");
    Console.WriteLine("5.- Salir");
}


