using System.Diagnostics;

namespace FamilyVacaton;
class Program
{
    static void Main(string[] args)
    {
        
        double budget = double.Parse(Console.ReadLine());
        double pricePerNight = double.Parse(Console.ReadLine());
        int nightsSpent = int.Parse(Console.ReadLine());
        int percentForExtraExpenses = int.Parse(Console.ReadLine());

        double neededMoneyforSpentNights = pricePerNight * nightsSpent;
        double moneyForExtraExpenses = budget * (percentForExtraExpenses / 100d);
        double finalMoneyNeeded = neededMoneyforSpentNights + moneyForExtraExpenses;

        if (budget > finalMoneyNeeded)
        {
            budget = budget - finalMoneyNeeded;
            Console.WriteLine($"Petrovi will be left with {budget:f2} leva after vacation.");
        }
        else
        {
            finalMoneyNeeded = finalMoneyNeeded - budget;
            Console.WriteLine($"{finalMoneyNeeded} leva needed.");
        }


    }
}