namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tornamentCounts = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int tornamentPointCounts = 0;
            double turnamentsWom = 0;
            for (int i = 0; i < tornamentCounts; i++)
            {
                string position = Console.ReadLine();
                if (position == "W")
                {
                    tornamentPointCounts += 2000;
                    turnamentsWom++;
                }
                else if (position == "F")
                {
                    tornamentPointCounts += 1200;
                }
                else if (position == "SF")
                {
                    tornamentPointCounts += 720;
                }
            }
            Console.WriteLine($"Final points: {tornamentPointCounts + startingPoints}");
            Console.WriteLine($"Average points: {tornamentPointCounts / tornamentCounts}");
            Console.WriteLine($"{turnamentsWom / tornamentCounts * 100:f2}%");
        }
    }
}
