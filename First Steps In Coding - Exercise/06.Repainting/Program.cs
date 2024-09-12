namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double sumNylon = (nylon + 2) * 1.50;
            double sumPaint = (paint + paint * 0.10) * 14.50;
            double sumThinner = thinner * 5.00;
            double sumBag = 0.40;
            double sum = sumNylon + sumPaint + sumThinner + sumBag;
            double sumMaster = (sum * 0.30) * hours;
            double finalSum = sum + sumMaster;
            Console.WriteLine($"{finalSum}");
        }
    }
}
