using System;

namespace tictactoe
{
    public class Harness
    {
        Game _game;
        IOutput _output;
        IInput[] _input = new IInput[2];

        public Harness(IOutput output, IInput inputPlayerFirst, IInput inputPlayerSecond)
        {
            _game = new Game();
            _output = output;
            _input[0] = inputPlayerFirst;
            _input[1] = inputPlayerSecond;
        }

        public void StartGame()
        {
            _output.ShowWelcome();

            while (!(_game.IsFinished()))
            {
                _output.ShowBoard(_game.GetBoard());

                char currentPlayer = _game.GetCurrentPlayer();

                _output.ShowCurrentPlayer(currentPlayer);

                while (true)
                {
                    int move = _input[_game.GetCurrentPlayerNo()].GetMove();
                    if (move == -1)
                    {
                        _output.ShowMoveError(currentPlayer, "INVALID_FIELD");
                        continue;
                    }

                    if (_game.MakeMove(move) == false)
                    {
                        _output.ShowMoveError(currentPlayer, "OCCUPIED_FIELD");
                        continue;
                    }
                    break;
                }
            }

            _output.ShowBoard(_game.GetBoard());
            if (_game.CheckWinner())
                _output.ShowWinner(_game.GetWinner());
            else
                _output.ShowDraw();
        }
    }
}
