namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int cakeSize = width * length;
            int totalPiecesTaken = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    int piecesLeft = cakeSize - totalPiecesTaken;
                    if (piecesLeft > 0)
                    {
                        Console.WriteLine($"{piecesLeft} pieces are left.");
                    }
                    else
                    {
                        Console.WriteLine($"No more cake left! You need {Math.Abs(piecesLeft)} pieces more.");
                    }
                    break;
                }
                int piecesTaken = int.Parse(input);
                totalPiecesTaken += piecesTaken;
                if (totalPiecesTaken >= cakeSize)
                {
                    Console.WriteLine($"No more cake left! You need " +
                                      $"{Math.Abs(totalPiecesTaken - cakeSize)} pieces more.");
                    break;
                }
            }
        }
    }
}
