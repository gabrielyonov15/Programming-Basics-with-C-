namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int totalTickets = 0;
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;
            while (movie != "Finish")
            {
                int seats = int.Parse(Console.ReadLine());
                int soldTickets = 0;
                string ticketType = Console.ReadLine();
                while (ticketType != "End")
                {
                    totalTickets++;
                    soldTickets++;
                    if (ticketType == "student")
                    {
                        studentTickets++;
                    }
                    else
                    if (ticketType == "standard")
                    {
                        standardTickets++;
                    }
                    else
                    if (ticketType == "kid")
                    {
                        kidTickets++;
                    }
                    if (soldTickets >= seats)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }
                double percentageFull = (double)soldTickets / seats * 100;
                Console.WriteLine($"{movie} - {percentageFull:f2}% full.");
                movie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(double)studentTickets / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{(double)standardTickets / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{(double)kidTickets / totalTickets * 100:f2}% kids tickets.");
        }
    }
}
