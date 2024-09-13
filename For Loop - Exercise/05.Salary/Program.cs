namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfTabs; i++)
            {
                string website = Console.ReadLine();
                switch (website)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }
            Console.WriteLine(salary);
        }
    }
}
