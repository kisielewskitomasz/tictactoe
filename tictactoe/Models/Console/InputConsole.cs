using System;
namespace tictactoe
{
    public class InputConsole : IInput
    {
        public int GetMove()
        {
            int move = -1;
            ConsoleKeyInfo key = Console.ReadKey();
            if (int.TryParse(key.KeyChar.ToString(), out move))
                if (move >= 0 && move <= 8)
                    return move;

            return -1;
        }
    }
}
