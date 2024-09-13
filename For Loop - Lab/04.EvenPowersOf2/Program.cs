namespace _04.EvenPowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            for (int i = 0; i <= n; i += 2)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }
        }
    }
}
