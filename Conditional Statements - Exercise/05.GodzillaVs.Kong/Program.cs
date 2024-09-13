namespace _05.GodzillaVs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfExtras = int.Parse(Console.ReadLine());
            double costumePricePerExtra = double.Parse(Console.ReadLine());
            double setCost = 0.10 * budget;
            double totalCostumeCost = numberOfExtras * costumePricePerExtra;
            if (numberOfExtras > 150)
            {
                totalCostumeCost *= 0.90;
            }
            double totalExpenses = setCost + totalCostumeCost;
            if (budget < totalExpenses)
            {
                double neededMoney = totalExpenses - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:F2} leva more.");
            }
            else
            {
                double remainingMoney = budget - totalExpenses;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {remainingMoney:F2} leva left.");
            }
        }
    }
}
