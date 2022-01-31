Sale sale = new Sale(100,DateTime.Now);
//sale.Show();

Console.WriteLine(sale.ShowInfo());
class Sale
{
    // Propiedades
    int total;
    DateTime date;

    // Constructor

    public Sale(int total, DateTime date) { 
    
        this.total = total;
        this.date = date;
    
    }

    // Metodos

    public string ShowInfo() {

        return total + " " + date.ToLongDateString();
    }

    public void Show()
    {
        // Mala practica
        Console.WriteLine("Hola soy una venta");
    }


}