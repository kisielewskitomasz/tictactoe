using System;
namespace tictactoe
{
    public class Harness
    {
        Game _game;
        Output _output;
        Input _inputPlayerFirst;
        Input _inputPlayerSecond;

        public Harness(Output output, Input inputPlayerFirst, Input inputPlayerSecond)
        {
            _game = new Game();
            _output = output;
            _inputPlayerFirst = inputPlayerFirst;
            _inputPlayerSecond = inputPlayerSecond;
        }

        public void StartGame()
        {
            _output.ShowWelcome();

            while(!(_game.IsFinished()))
            {
                
            }
        }
    }




}
