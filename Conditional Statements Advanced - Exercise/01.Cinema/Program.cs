namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int lines = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double result = lines * columns;
            result += 0.00;
            switch (projection)
            {
                case "Premiere":
                    result *= 12.00;
                    break;
                case "Normal":
                    result *= 7.50;
                    break;
                case "Discount":
                    result *= 5.00;
                    break;
            }
            Console.WriteLine("{0:f2} leva", result);
        }
    }
}
