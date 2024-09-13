namespace _02.GreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            if (number1 <= number2)
            {
                Console.WriteLine(number2);
            }
            else
            if (number1 >= number2)
            {
                Console.WriteLine(number1);
            }
        }
    }
}
