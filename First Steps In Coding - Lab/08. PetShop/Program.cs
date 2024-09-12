namespace _08._PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packet1 = int.Parse(Console.ReadLine());
            double dog = 2.50 * packet1;
            int packet2 = int.Parse(Console.ReadLine());
            int cat = 4 * packet2;
            double finalSum = dog + cat;
            Console.WriteLine($"{finalSum} lv.");
        }
    }
}
