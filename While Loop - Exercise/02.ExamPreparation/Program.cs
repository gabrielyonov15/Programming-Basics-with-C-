namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failedThreshold = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            int solveProblemsCount = 0;
            double gradesSum = 0;
            string lastProblem = "";
            bool isFailed = true;
            while (failedTimes < failedThreshold)
            {
                string problemName = Console.ReadLine();
                if ("Enough" == problemName)
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTimes++;
                }
                gradesSum += grade;
                solveProblemsCount++;
                lastProblem = problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedThreshold} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum / solveProblemsCount:F2}");
                Console.WriteLine($"Number of problems: {solveProblemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
