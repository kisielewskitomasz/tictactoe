using System;
namespace client
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
                if (move < 0 || move > 8)
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
