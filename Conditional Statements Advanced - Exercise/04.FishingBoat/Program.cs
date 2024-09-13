namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishermen = int.Parse(Console.ReadLine());
            double boatRentPrice = 0;
            switch (season)
            {
                case "Spring":
                    boatRentPrice = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    boatRentPrice = 4200;
                    break;
                case "Winter":
                    boatRentPrice = 2600;
                    break;
            }
            if (numberOfFishermen <= 6)
            {
                boatRentPrice *= 0.90;
            }
            else if (numberOfFishermen <= 11)
            {
                boatRentPrice *= 0.85;
            }
            else
            {
                boatRentPrice *= 0.75;
            }
            if (numberOfFishermen % 2 == 0 && season != "Autumn")
            {
                boatRentPrice *= 0.95;
            }
            double remainingMoney = budget - boatRentPrice;
            if (remainingMoney >= 0)
            {
                Console.WriteLine($"Yes! You have {remainingMoney:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(remainingMoney):F2} leva.");
            }
        }
    }
}
