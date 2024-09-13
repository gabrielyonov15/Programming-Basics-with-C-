namespace _02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                int evenSum = 0;
                int oddSum = 0;
                int number = i;
                for (int j = 1; j <= 6; j++)
                {
                    int digit = number % 10;
                    number /= 10;
                    if (j % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                    found = true;
                }
            }
        }
    }
}
