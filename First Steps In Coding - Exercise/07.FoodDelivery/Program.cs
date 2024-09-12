namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegetarian = int.Parse(Console.ReadLine());
            double priceChicken = chicken * 10.35;
            double priceFish = fish * 12.40;
            double priceVegetarian = vegetarian * 8.15;
            double menu = priceChicken + priceFish + priceVegetarian;
            double dessert = menu * 0.20;
            double delivery = 2.50;
            double price = menu + dessert + delivery;
            Console.WriteLine(price);
        }
    }
}
