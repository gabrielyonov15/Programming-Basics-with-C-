namespace _05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            int coinsCount = 0;
            int changeInCents = (int)(change * 100);
            int twoLevaCoins = 0;
            int oneLevaCoins = 0;
            int fiftyStotinkiCoins = 0;
            int twentyStotinkiCoins = 0;
            int tenStotinkiCoins = 0;
            int fiveStotinkiCoins = 0;
            int twoStotinkiCoins = 0;
            int oneStotinkaCoins = 0;
            while (changeInCents > 0)
            {
                if (changeInCents >= 200)
                {
                    twoLevaCoins = changeInCents / 200;
                    changeInCents %= 200;
                }
                else if (changeInCents >= 100)
                {
                    oneLevaCoins = changeInCents / 100;
                    changeInCents %= 100;
                }
                else if (changeInCents >= 50)
                {
                    fiftyStotinkiCoins = changeInCents / 50;
                    changeInCents %= 50;
                }
                else if (changeInCents >= 20)
                {
                    twentyStotinkiCoins = changeInCents / 20;
                    changeInCents %= 20;
                }
                else if (changeInCents >= 10)
                {
                    tenStotinkiCoins = changeInCents / 10;
                    changeInCents %= 10;
                }
                else if (changeInCents >= 5)
                {
                    fiveStotinkiCoins = changeInCents / 5;
                    changeInCents %= 5;
                }
                else if (changeInCents >= 2)
                {
                    twoStotinkiCoins = changeInCents / 2;
                    changeInCents %= 2;
                }
                else if (changeInCents >= 1)
                {
                    oneStotinkaCoins = changeInCents / 1;
                    changeInCents %= 1;
                }
            }
            coinsCount = twoLevaCoins + oneLevaCoins + fiftyStotinkiCoins +
                         twentyStotinkiCoins + tenStotinkiCoins + fiveStotinkiCoins +
                         twoStotinkiCoins + oneStotinkaCoins;
            Console.WriteLine($"{coinsCount}");
        }
    }
}
