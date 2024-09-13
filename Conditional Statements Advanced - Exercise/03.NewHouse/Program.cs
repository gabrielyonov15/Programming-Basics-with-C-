namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            if (flowers == "Roses")
            {
                price = numberOfFlowers * 5.00;
                if (numberOfFlowers > 80)
                {
                    price *= 0.90;
                }
            }
            else if (flowers == "Dahlias")
            {
                price = numberOfFlowers * 3.80;
                if (numberOfFlowers > 90)
                {
                    price *= 0.85;
                }
            }
            else if (flowers == "Tulips")
            {
                price = numberOfFlowers * 2.80;
                if (numberOfFlowers > 80)
                {
                    price *= 0.85;
                }
            }
            else if (flowers == "Narcissus")
            {
                price = numberOfFlowers * 3.00;
                if (numberOfFlowers < 120)
                {
                    price *= 1.15;
                }
            }
            else if (flowers == "Gladiolus")
            {
                price = numberOfFlowers * 2.50;
                if (numberOfFlowers < 80)
                {
                    price *= 1.20;
                }
            }
            double result = budget - price;
            if (result >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowers} and {result:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(result):F2} leva more.");
            }
        }
    }
}
