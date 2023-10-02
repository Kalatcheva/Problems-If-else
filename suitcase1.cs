using System.Diagnostics;

namespace Zoo;
class Program
{
    static void Main(string[] args)
    {
        double priceForSuitcaseOver20kgs = double.Parse(Console.ReadLine());
        double suitcaseKgs = double.Parse(Console.ReadLine());
        int daysUntilVacation = int.Parse(Console.ReadLine());
        int suitcaseCount = int.Parse(Console.ReadLine());


        if(suitcaseKgs <= 10)
        {
            priceForSuitcaseOver20kgs *= 0.25;

        }
        else if(suitcaseKgs > 10 && suitcaseKgs <= 20)
        {
            priceForSuitcaseOver20kgs *= 0.6;
        }

        if(daysUntilVacation > 30)
        {
            priceForSuitcaseOver20kgs += priceForSuitcaseOver20kgs * 0.15;

        }
        else if(daysUntilVacation > 7 &&  daysUntilVacation <= 30)
        {
            priceForSuitcaseOver20kgs += priceForSuitcaseOver20kgs * 0.25;
        }
        else if(daysUntilVacation > 7)
        {
            priceForSuitcaseOver20kgs += priceForSuitcaseOver20kgs * 0.45;
        }

        double neededMoney = priceForSuitcaseOver20kgs * suitcaseKgs;
        Console.WriteLine($"The total price of bags is: {neededMoney:f2} lv.");

    }
}