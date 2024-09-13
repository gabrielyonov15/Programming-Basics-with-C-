namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalGroups = int.Parse(Console.ReadLine());
            int totalClimbers = 0;
            int musalaClimbers = 0;
            int montBlancClimbers = 0;
            int kilimanjaroClimbers = 0;
            int k2Climbers = 0;
            int everestClimbers = 0;
            for (int i = 0; i < totalGroups; i++)
            {
                int groupSize = int.Parse(Console.ReadLine());
                totalClimbers += groupSize;
                if (groupSize <= 5)
                {
                    musalaClimbers += groupSize;
                }
                else if (groupSize <= 12)
                {
                    montBlancClimbers += groupSize;
                }
                else if (groupSize <= 25)
                {
                    kilimanjaroClimbers += groupSize;
                }
                else if (groupSize <= 40)
                {
                    k2Climbers += groupSize;
                }
                else
                {
                    everestClimbers += groupSize;
                }
            }
            Console.WriteLine($"{(musalaClimbers / (double)totalClimbers) * 100:F2}%");
            Console.WriteLine($"{(montBlancClimbers / (double)totalClimbers) * 100:F2}%");
            Console.WriteLine($"{(kilimanjaroClimbers / (double)totalClimbers) * 100:F2}%");
            Console.WriteLine($"{(k2Climbers / (double)totalClimbers) * 100:F2}%");
            Console.WriteLine($"{(everestClimbers / (double)totalClimbers) * 100:F2}%");
        }
    }
}
