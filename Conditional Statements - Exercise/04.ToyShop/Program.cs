namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            double pricePuzzle = puzzle * 2.60;
            double priceDolls = dolls * 3;
            double priceBears = bears * 4.10;
            double priceMinions = minions * 8.20;
            double priceTrucks = trucks * 2;
            double sum = pricePuzzle + priceDolls + priceBears + priceMinions + priceTrucks;
            int toy = puzzle + dolls + bears + minions + trucks;

            if (toy >= 50)
            {
                sum = sum - (sum * 25 / 100);
            }
            double rent = sum * 0.1;
            double finalIncom = sum - rent;
            if (finalIncom >= trip)
            {
                double moneyLeft = finalIncom - trip;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double neededMoney = trip - finalIncom;
                Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");
            }
        }
    }
}
