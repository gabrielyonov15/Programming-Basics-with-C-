namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int nonPrimeSum = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                int number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                bool isPrime = true;
                if (number <= 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 2; i <= Math.Sqrt(number); i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime)
                {
                    primeSum += number;
                }
                else
                {
                    nonPrimeSum += number;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
