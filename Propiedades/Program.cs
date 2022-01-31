Sale sale = new Sale(100, DateTime.Now);

sale.Total = 120;

Console.WriteLine(sale.Total);
class Sale
{

    private int total;

    public int Total
    {
        get { return total; }

        set
        {

            if (value < 0) value = 0;


            total = value;

        }
    }

    private DateTime date;

    public string Date
    {
        get { return date.ToLongDateString(); }
    }

    public Sale(int Total, DateTime date)
    {

        this.Total = Total;
        this.date = date;

    }

}