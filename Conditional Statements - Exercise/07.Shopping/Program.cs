namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budgetPetar = double.Parse(Console.ReadLine());
            int countVideocards = int.Parse(Console.ReadLine());
            int countProcesors = int.Parse(Console.ReadLine());
            int countRam = int.Parse(Console.ReadLine());
            double allPriceVideocards = countVideocards * 250;
            double allPrice = allPriceVideocards + countProcesors * allPriceVideocards * 0.35 + countRam * allPriceVideocards * 0.1;
            if (countVideocards > countProcesors)
            {
                allPrice = allPrice * 0.85;
            }
            if (budgetPetar >= allPrice)
            {
                Console.WriteLine($"You have {budgetPetar - allPrice:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {allPrice - budgetPetar:F2} leva more!");
            }
        }
    }
}
