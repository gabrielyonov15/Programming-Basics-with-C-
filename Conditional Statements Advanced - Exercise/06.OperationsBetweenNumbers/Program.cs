namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double result = 0;
            string output = "";
            switch (operation)
            {
                case '+':
                    result = N1 + N2;
                    output = $"{N1} + {N2} = {result}";
                    break;
                case '-':
                    result = N1 - N2;
                    output = $"{N1} - {N2} = {result}";
                    break;
                case '*':
                    result = N1 * N2;
                    output = $"{N1} * {N2} = {result}";
                    break;
                case '/':
                    if (N2 == 0)
                    {
                        output = $"Cannot divide {N1} by zero";
                    }
                    else
                    {
                        result = (double)N1 / N2;
                        output = $"{N1} / {N2} = {result:F2}";
                    }
                    break;
                case '%':
                    if (N2 == 0)
                    {
                        output = $"Cannot divide {N1} by zero";
                    }
                    else
                    {
                        result = N1 % N2;
                        output = $"{N1} % {N2} = {result}";
                    }
                    break;
            }
            if (operation == '+' || operation == '-' || operation == '*')
            {
                string evenOrOdd = result % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"{output} - {evenOrOdd}");
            }
            else
            {
                Console.WriteLine(output);
            }
        }
    }
}
