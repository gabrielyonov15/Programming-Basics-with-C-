namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int totalSteps = 0;
            while (totalSteps < goal)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    totalSteps += stepsToHome;
                    if (totalSteps < goal)
                    {
                        int stepsDiff = goal - totalSteps;
                        Console.WriteLine($"{stepsDiff} more steps to reach goal.");
                        break;
                    }
                }
                else
                {
                    int steps = int.Parse(input);
                    totalSteps += steps;
                }
            }
            if (totalSteps >= goal)
            {
                int stepsOverGoal = totalSteps - goal;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsOverGoal} steps over the goal!");
            }
        }
    }
}
