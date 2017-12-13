using System;

namespace tictactoe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Game game = new Game();

            Console.WriteLine($"Cur player: {game.GetCurrentPlayer()}");
            Console.WriteLine($"Finished: {game.IsFinished()}");
            Console.WriteLine($"Good move: {game.MakeMove(0)}");
            Console.WriteLine($"Checking winner: {game.CheckWinner()}");
            game.PrintBoard();

            Console.WriteLine($"Cur player: {game.GetCurrentPlayer()}");
            Console.WriteLine($"Finished: {game.IsFinished()}");
            Console.WriteLine($"Good move: {game.MakeMove(1)}");
            Console.WriteLine($"Checking winner: {game.CheckWinner()}");
            game.PrintBoard();

            Console.WriteLine($"Cur player: {game.GetCurrentPlayer()}");
            Console.WriteLine($"Finished: {game.IsFinished()}");
            Console.WriteLine($"Good move: {game.MakeMove(4)}");
            Console.WriteLine($"Checking winner: {game.CheckWinner()}");
            game.PrintBoard();

            Console.WriteLine($"Cur player: {game.GetCurrentPlayer()}");
            Console.WriteLine($"Finished: {game.IsFinished()}");
            Console.WriteLine($"Good move: {game.MakeMove(2)}");
            Console.WriteLine($"Checking winner: {game.CheckWinner()}");
            game.PrintBoard();

            Console.WriteLine($"Cur player: {game.GetCurrentPlayer()}");
            Console.WriteLine($"Finished: {game.IsFinished()}");
            Console.WriteLine($"Good move: {game.MakeMove(8)}");
            Console.WriteLine($"Checking winner: {game.CheckWinner()}");
            game.PrintBoard();

            Console.WriteLine($"Cur player: {game.GetCurrentPlayer()}");
            Console.WriteLine($"Finished: {game.IsFinished()}");
            Console.WriteLine($"Good move: {game.MakeMove(5)}");
            Console.WriteLine($"Checking winner: {game.CheckWinner()}");
            game.PrintBoard();
        }
    }
}
