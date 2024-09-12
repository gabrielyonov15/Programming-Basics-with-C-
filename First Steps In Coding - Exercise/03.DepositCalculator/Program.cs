namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine()) / 100;
            double interest = deposit * rate;
            double interestForOneMonth = interest / 12;
            double result = deposit + term * interestForOneMonth;
            Console.WriteLine(result);
        }
    }
}
