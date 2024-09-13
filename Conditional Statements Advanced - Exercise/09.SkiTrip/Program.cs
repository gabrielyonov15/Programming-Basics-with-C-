namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();
            double pricePerNight = 0;
            switch (roomType)
            {
                case "room for one person":
                    pricePerNight = 18.00;
                    break;
                case "apartment":
                    pricePerNight = 25.00;
                    break;
                case "president apartment":
                    pricePerNight = 35.00;
                    break;
            }
            double totalPrice = (days - 1) * pricePerNight;
            if (days > 15)
            {
                switch (roomType)
                {
                    case "room for one person":
                        break;
                    case "apartment":
                        totalPrice *= 0.50;
                        break;
                    case "president apartment":
                        totalPrice *= 0.80;
                        break;
                }
            }
            else if (days >= 10)
            {
                switch (roomType)
                {
                    case "room for one person":
                        break;
                    case "apartment":
                        totalPrice *= 0.65;
                        break;
                    case "president apartment":
                        totalPrice *= 0.85;
                        break;
                }
            }
            else
            {
                switch (roomType)
                {
                    case "room for one person":
                        break;
                    case "apartment":
                        totalPrice *= 0.70;
                        break;
                    case "president apartment":
                        totalPrice *= 0.90;
                        break;
                }
            }
            if (feedback == "positive")
            {
                totalPrice *= 1.25;
            }
            else
            {
                totalPrice *= 0.90;
            }
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
