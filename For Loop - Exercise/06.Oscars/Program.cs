namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double initialPoints = double.Parse(Console.ReadLine());
            int judgesCount = int.Parse(Console.ReadLine());
            double totalPoints = initialPoints;
            for (int i = 0; i < judgesCount; i++)
            {
                string judgeName = Console.ReadLine();
                double judgePoints = double.Parse(Console.ReadLine());
                int nameLength = judgeName.Length;
                double currentPoints = nameLength * judgePoints / 2.0;
                totalPoints += currentPoints;
                if (totalPoints >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:F1}!");
                    return;
                }
            }
            double neededPoints = 1250.5 - totalPoints;
            Console.WriteLine($"Sorry, {actorName} you need {neededPoints:F1} more!");
        }
    }
}
