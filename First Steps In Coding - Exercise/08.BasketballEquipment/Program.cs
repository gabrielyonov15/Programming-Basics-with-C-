namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fee = int.Parse(Console.ReadLine());
            double sneakers = fee - (fee * 0.40);
            double outfit = sneakers - (sneakers * 0.20);
            double ball = outfit / 4;
            double accessory = ball / 5;
            double sum = fee + sneakers + outfit + ball + accessory;
            Console.WriteLine(sum);
        }
    }
}
