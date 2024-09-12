namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pen = int.Parse(Console.ReadLine());
            int marker = int.Parse(Console.ReadLine());
            int preparation = int.Parse(Console.ReadLine());
            int reduction = int.Parse(Console.ReadLine());
            double pricePen = pen * 5.80;
            double priceMarker = marker * 7.20;
            double pricePreparation = preparation * 1.20;
            double materials = pricePen + priceMarker + pricePreparation;
            double priceReduction = materials - (materials * reduction / 100);
            Console.WriteLine(priceReduction);
        }
    }
}
