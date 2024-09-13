namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int days = 0;
            int consecutiveSpendDays = 0;
            while (availableMoney < neededMoney && consecutiveSpendDays < 5)
            {
                string action = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                if (action == "save")
                {
                    availableMoney += amount;
                    consecutiveSpendDays = 0;
                }
                else if (action == "spend")
                {
                    availableMoney -= amount;
                    consecutiveSpendDays++;
                }
                if (availableMoney < 0)
                {
                    availableMoney = 0;
                }
                days++;
            }
            if (consecutiveSpendDays == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            else
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
