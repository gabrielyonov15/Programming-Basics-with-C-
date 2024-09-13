namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;
            int countP4 = 0;
            int countP5 = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    countP1++;
                }
                else if (number >= 200 && number <= 399)
                {
                    countP2++;
                }
                else if (number >= 400 && number <= 599)
                {
                    countP3++;
                }
                else if (number >= 600 && number <= 799)
                {
                    countP4++;
                }
                else
                {
                    countP5++;
                }
            }
            double p1 = (double)countP1 / n * 100;
            double p2 = (double)countP2 / n * 100;
            double p3 = (double)countP3 / n * 100;
            double p4 = (double)countP4 / n * 100;
            double p5 = (double)countP5 / n * 100;
            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}
