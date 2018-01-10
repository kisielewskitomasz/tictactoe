using System;
namespace tictactoe
{
    public class Player
    {
        char _sign;
        IInput _input;
        IOutput _output;

        public char Sign { get => _sign; set => _sign = value; }
        public IInput Input { get => _input; set => _input = value; }
        public IOutput Output { get => _output; set => _output = value; }

        public Player(char sign, IInput playerInput, IOutput playerOutput)
        {
            _sign = sign;
            _input = playerInput;
            _output = playerOutput;
        }
    }
}
