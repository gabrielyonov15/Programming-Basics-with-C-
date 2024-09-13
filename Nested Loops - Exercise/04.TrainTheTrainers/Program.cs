namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int judgesCount = int.Parse(Console.ReadLine());
            double totalGradeSum = 0;
            int presentationsCount = 0;
            while (true)
            {
                string presentationName = Console.ReadLine();
                if (presentationName == "Finish")
                {
                    break;
                }
                double presentationGradeSum = 0;
                for (int i = 0; i < judgesCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    presentationGradeSum += grade;
                }
                double averageGrade = presentationGradeSum / judgesCount;
                totalGradeSum += averageGrade;
                presentationsCount++;
                Console.WriteLine($"{presentationName} - {averageGrade:f2}.");
            }
            double finalAssessment = totalGradeSum / presentationsCount;
            Console.WriteLine($"Student's final assessment is {finalAssessment:f2}.");
        }
    }
}
