namespace _07._ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int project = int.Parse(Console.ReadLine());
            int hours = project * 3;
            Console.WriteLine($"The architect {name} will need {hours} hours to complete {project} project/s.");
        }
    }
}
