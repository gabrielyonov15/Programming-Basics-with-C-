namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grades = 1;
            double allGrades = 0;
            int badGrades = 0;
            while (grades <= 12)
            {
                double currentGrade = double.Parse(Console.ReadLine());
                if (currentGrade < 4.00)
                {
                    badGrades++;
                    if (badGrades < 2)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{name} has been excluded at {grades} grade");
                        return;
                    }
                }
                grades++;
                allGrades += currentGrade;
            }
            double averageGrade = allGrades / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
        }
    }
}
