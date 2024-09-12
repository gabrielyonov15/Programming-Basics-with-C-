namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            int fishTank = lenght * width * height;
            double liter = fishTank * 0.001;
            double space = percent / 100;
            double litersNeeded = liter * (1 - space);
            Console.WriteLine(litersNeeded);
        }
    }
}
