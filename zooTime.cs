namespace Zoo;
class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        double fuel = double.Parse(Console.ReadLine());
        string day = Console.ReadLine();

        double fuelPrice = fuel * 2.8;
        double moneyNeeded = fuelPrice + 85;

        if(day == "Saturday")
        {
            moneyNeeded = moneyNeeded * 0.8;

            if(moneyNeeded <= budget)
            {
                budget = budget - moneyNeeded;
                Console.WriteLine($"Zoo time! Money left: {budget:f2} lv.");
            }
            else if(moneyNeeded >= fuel)
            {
                moneyNeeded = moneyNeeded - budget;
                Console.WriteLine($"Not enough money! Money needed: {moneyNeeded:f2} lv.");
            }
        }
        else if(day == "Sunday")
        {
            moneyNeeded = moneyNeeded * 0.75;

            if (moneyNeeded <= budget)
            {
                budget = budget - moneyNeeded;
                Console.WriteLine($"Zoo time! Money left: {budget:f2} lv.");
            }
            else if (moneyNeeded >= fuel)
            {
                moneyNeeded = moneyNeeded - budget;
                Console.WriteLine($"Not enough money! Money needed: {moneyNeeded:f2} lv.");
            }
        }
        

    }
}