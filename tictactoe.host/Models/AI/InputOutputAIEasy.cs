using System;
namespace tictactoe
{
    public class InputOutputAIEasy : InputOutputAI
    {
        public override int GetMove()
        {
            return _rnd.Next(0, 9);
        }
    }
}
