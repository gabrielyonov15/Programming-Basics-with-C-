namespace _05.SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            if (city == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        double price1 = 0.50 * quantity;
                        Console.WriteLine(price1);
                        break;
                    case "water":
                        double price2 = 0.80 * quantity;
                        Console.WriteLine(price2);
                        break;
                    case "beer":
                        double price3 = 1.20 * quantity;
                        Console.WriteLine(price3);
                        break;
                    case "sweets":
                        double price4 = 1.45 * quantity;
                        Console.WriteLine(price4);
                        break;
                    case "peanuts":
                        double price5 = 1.60 * quantity;
                        Console.WriteLine(price5);
                        break;
                }
            }
            else
                if (city == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        double price1 = 0.40 * quantity;
                        Console.WriteLine(price1);
                        break;
                    case "water":
                        double price2 = 0.70 * quantity;
                        Console.WriteLine(price2);
                        break;
                    case "beer":
                        double price3 = 1.15 * quantity;
                        Console.WriteLine(price3);
                        break;
                    case "sweets":
                        double price4 = 1.30 * quantity;
                        Console.WriteLine(price4);
                        break;
                    case "peanuts":
                        double price5 = 1.50 * quantity;
                        Console.WriteLine(price5);
                        break;
                }
            }
            else
                if (city == "Varna")
            {
                switch (product)
                {
                    case "coffee":
                        double price1 = 0.45 * quantity;
                        Console.WriteLine(price1);
                        break;
                    case "water":
                        double price2 = 0.70 * quantity;
                        Console.WriteLine(price2);
                        break;
                    case "beer":
                        double price3 = 1.10 * quantity;
                        Console.WriteLine(price3);
                        break;
                    case "sweets":
                        double price4 = 1.35 * quantity;
                        Console.WriteLine(price4);
                        break;
                    case "peanuts":
                        double price5 = 1.55 * quantity;
                        Console.WriteLine(price5);
                        break;
                }
            }
        }
    }
}
