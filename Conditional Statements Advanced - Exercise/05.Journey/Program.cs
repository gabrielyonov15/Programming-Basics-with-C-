namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string vacationType = "";
            double moneySpent = 0;
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    vacationType = "Camp";
                    moneySpent = budget * 0.30;
                }
                else if (season == "winter")
                {
                    vacationType = "Hotel";
                    moneySpent = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    vacationType = "Camp";
                    moneySpent = budget * 0.40;
                }
                else if (season == "winter")
                {
                    vacationType = "Hotel";
                    moneySpent = budget * 0.80;
                }
            }
            else
            {
                destination = "Europe";
                vacationType = "Hotel";
                moneySpent = budget * 0.90;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{vacationType} - {moneySpent:F2}");
        }
    }
}
