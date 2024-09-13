namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double salesVolume = double.Parse(Console.ReadLine());
            double commissionRate = 0;
            switch (city)
            {
                case "Sofia":
                    if (salesVolume >= 0 && salesVolume <= 500)
                        commissionRate = 0.05;
                    else if (salesVolume > 500 && salesVolume <= 1000)
                        commissionRate = 0.07;
                    else if (salesVolume > 1000 && salesVolume <= 10000)
                        commissionRate = 0.08;
                    else if (salesVolume > 10000)
                        commissionRate = 0.12;
                    break;

                case "Varna":
                    if (salesVolume >= 0 && salesVolume <= 500)
                        commissionRate = 0.045;
                    else if (salesVolume > 500 && salesVolume <= 1000)
                        commissionRate = 0.075;
                    else if (salesVolume > 1000 && salesVolume <= 10000)
                        commissionRate = 0.1;
                    else if (salesVolume > 10000)
                        commissionRate = 0.13;
                    break;
                case "Plovdiv":
                    if (salesVolume >= 0 && salesVolume <= 500)
                        commissionRate = 0.055;
                    else if (salesVolume > 500 && salesVolume <= 1000)
                        commissionRate = 0.08;
                    else if (salesVolume > 1000 && salesVolume <= 10000)
                        commissionRate = 0.12;
                    else if (salesVolume > 10000)
                        commissionRate = 0.145;
                    break;
                default:
                    Console.WriteLine("error");
                    return;
            }
            if (commissionRate > 0)
            {
                double commission = salesVolume * commissionRate;
                Console.WriteLine($"{commission:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
