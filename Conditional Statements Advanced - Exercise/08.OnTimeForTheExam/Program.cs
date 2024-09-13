namespace _08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesEXAM = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());
            int totalMinutesExam = hourExam * 60 + minutesEXAM;
            int totalMinutesArrival = hourArrival * 60 + minutesArrival;
            int totalMinutesDiferent = totalMinutesExam - totalMinutesArrival;
            if (totalMinutesDiferent >= 0 && totalMinutesDiferent <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{totalMinutesDiferent} minutes before the start");
            }
            else if (totalMinutesDiferent > 30)
            {
                Console.WriteLine("Early");
                if (totalMinutesDiferent >= 60)
                {
                    int hours = totalMinutesDiferent / 60;
                    int minutes = totalMinutesDiferent - hours * 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours before the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{totalMinutesDiferent} minutes before the start");
                }
            }
            else if (totalMinutesDiferent < 0)
            {
                Console.WriteLine("Late");
                totalMinutesDiferent = -totalMinutesDiferent;
                if (totalMinutesDiferent >= 60)
                {
                    int hours = totalMinutesDiferent / 60;
                    int minutes = totalMinutesDiferent - hours * 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours after the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{totalMinutesDiferent} minutes after the start");
                }
            }
        }
    }
}
