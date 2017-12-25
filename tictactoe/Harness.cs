using System;
using System.Collections.Generic;

namespace tictactoe
{
    public class Harness
    {
        protected Game _game;
        protected List<IInput> _input = new List<IInput>();
        protected List<IOutput> _output = new List<IOutput>();
        protected bool _hotseat;

        public Harness(List<IInput> inputs, List<IOutput> outputs)
        {
            _game = new Game();
            foreach (var input in inputs)
                _input.Add(input);
            foreach (var output in outputs)
                _output.Add(output);

            _hotseat |= _output[0].GetType() == _output[1].GetType();
        }

        public void StartGame()
        {
            foreach (var output in _output)
            {
                output.ShowWelcome();
                if (_hotseat) break;
            }

            while (!(_game.IsFinished()))
            {
                char currentPlayer = _game.GetCurrentPlayer();
                int currentPlayerNo = _game.GetCurrentPlayerNo();

                foreach (var output in _output)
                {
                    output.ShowBoard(_game.GetBoard());
                    output.ShowCurrentPlayer(currentPlayer);
                    if (_hotseat) break;
                }

                while (true)
                {
                    int move = _input[currentPlayerNo].GetMove();
                    if (move == -1)
                    {
                        _output[currentPlayerNo].ShowMoveError(currentPlayer, "INVALID_FIELD");
                        continue;
                    }

                    if (_game.MakeMove(move) == false)
                    {
                        _output[currentPlayerNo].ShowMoveError(currentPlayer, "OCCUPIED_FIELD");
                        continue;
                    }
                    break;
                }
            }

            foreach (var output in _output)
            {
                output.ShowBoard(_game.GetBoard());
                if (_game.CheckWinner())
                    output.ShowWinner(_game.GetWinner());
                else
                    output.ShowDraw();
                if (_hotseat) break;
            }
        }
    }
}
