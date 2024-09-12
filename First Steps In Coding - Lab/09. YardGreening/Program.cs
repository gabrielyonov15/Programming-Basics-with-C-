namespace _09._YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yardGreening = double.Parse(Console.ReadLine());
            double price = yardGreening * 7.61;
            double discount = 0.18 * price;
            double finalPrice = price - discount;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
