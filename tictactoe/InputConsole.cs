using System;
namespace tictactoe
{
    public class InputConsole : IInput
    {
        public int GetMove()
        {
            int move;
            try
            {
                ConsoleKeyInfo key = Console.ReadKey();
                move = int.Parse(key.KeyChar.ToString());
                if (move < 0 || move > 9)
                    return -1;
                return move;
            }
            catch (FormatException)
            {
                return -1;
            }
        }
    }
}
