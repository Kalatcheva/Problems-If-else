namespace SoftUni.Sport;

internal class CatalogRow
{

    public CatalogRow(string sport, bool isFemale, int price)
    {

        this.Sport = sport;
        this.IsFemale = isFemale;
        this.Price = price;

    }

    public string Sport { get; set; }

    public bool IsFemale { get; set; }

    public int Price { get; set; }

    public double GetAgePrice(int age)
    {
        return age >= 18 ? this.Price : this.Price / 2d;
    }

}

internal class Program
{
    static void Main(string[] args)
    {

        #region Catalog information

        CatalogRow[] catalog = new CatalogRow[] 
        { 

            new CatalogRow("gym", true, 36),
            new CatalogRow("gym", false, 43),

            new CatalogRow("boxing", true, 37),
            new CatalogRow("boxing", false, 34),

            new CatalogRow("yoga", true, 40),
            new CatalogRow("yoga", false, 46),

            new CatalogRow("zumba", true, 31),
            new CatalogRow("zumba", false, 31),

            new CatalogRow("dances", true, 53),
            new CatalogRow("dances", false, 58),

            new CatalogRow("pilates", true, 37),
            new CatalogRow("pilates", false, 43),

            new CatalogRow("swimming", true, 75),
            new CatalogRow("swimming", false, 70),

        };

        #endregion

        #region Read from console

        // Read ex params from console

        double budget = double.Parse(Console.ReadLine());
        bool isFemale = Console.ReadLine() == "f" ? true : false;
        int age = int.Parse(Console.ReadLine());
        string sport = Console.ReadLine();

        #endregion

        #region Print result

        CatalogRow targetRow = catalog.Where(x => x.Sport == sport.ToLower() && x.IsFemale == isFemale).FirstOrDefault();

        double targetAgePrice = targetRow.GetAgePrice(age);

        if (targetAgePrice <= budget)
        {
            Console.WriteLine("You purchased a 1 month pass for Dances.");
        }
        else
        {
            Console.WriteLine($"You need ${targetAgePrice - budget} more.");
        }

        #endregion

    }
}