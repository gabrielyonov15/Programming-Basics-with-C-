namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int time = numberOfPages / pages;
            int hoursADay = time / days;
            Console.WriteLine(hoursADay);
        }
    }
}
