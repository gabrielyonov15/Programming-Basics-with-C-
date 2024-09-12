namespace _04._InchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inhes = double.Parse(Console.ReadLine());
            double centimeters = inhes * 2.54;
            Console.WriteLine(centimeters);
        }
    }
}
