namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double moneyGift = 0;
            int toysCount = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyGift += (i * 10) / 2;
                    moneyGift -= 1;
                }
                else
                {
                    toysCount++;
                }
            }
            double totalMoney = moneyGift + (toysCount * toyPrice);
            if (totalMoney >= washingMachinePrice)
            {
                double remainingMoney = totalMoney - washingMachinePrice;
                Console.WriteLine($"Yes! {remainingMoney:F2}");
            }
            else
            {
                double neededMoney = washingMachinePrice - totalMoney;
                Console.WriteLine($"No! {neededMoney:F2}");
            }
        }
    }
}
