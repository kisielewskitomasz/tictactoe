using System;
namespace tictactoe
{
    public class OutputConsole : IOutput
    {
        public void ShowBoard(Board board)
        {
            char[] field = board.Get();
 
            for (int i = 0; i < 9; i++)
            {
                if (field[i] == Fields.Empty)
                    field[i] = Convert.ToChar(i + 48);
            }
            Console.WriteLine("");
            Console.WriteLine($" {field[0]} | {field[1]} | {field[2]} ");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($" {field[3]} | {field[4]} | {field[5]} ");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($" {field[6]} | {field[7]} | {field[8]} ");
        }

        public void ShowCurrentPlayer(char currentPlayer)
        {
            Console.WriteLine($"Current player is: {currentPlayer}");
        }

        public void ShowDraw()
        {
            Console.WriteLine("DRAW! Nobody wins!");
        }

        public void ShowMoveError(char currentPlayer, string codeError)
        {
            Console.WriteLine($"\nYour move was invalid. Reason: {codeError}");
        }

        public void ShowGreeting()
        {
            Console.WriteLine("Welcome in TicTacToe game");
        }

        public void ShowWinner(char winner)
        {
            Console.WriteLine($"WIN! Player {winner} wins the game!");
        }
    }
}
