using System;
using System.Collections.Generic;

namespace tictactoe
{
    public class Harness
    {
        protected Game _game;
        protected List<Player> _playersList;
        protected bool _hotseat;

        public Harness(List<Player> playersList)
        {
            _game = new Game(playersList);
            _playersList = playersList;
            _hotseat |= _playersList[0].Output.GetType() == _playersList[1].Output.GetType();
        }

        public void StartGame()
        {
            foreach (var player in _playersList)
            {
                player.Output.ShowGreeting();
                if (_hotseat) break;
            }

            while (!(_game.IsFinished()))
            {
                char currentPlayer = _game.GetCurrentPlayer();
                int currentPlayerNo = _game.GetCurrentPlayerNo();

                foreach (var player in _playersList)
                {
                    player.Output.ShowBoard(_game.GetBoard());
                    player.Output.ShowCurrentPlayer(currentPlayer);
                    if (_hotseat) break;
                }

                while (true)
                {
                    int move = _playersList[currentPlayerNo].Input.GetMove();
                    if (move == -1)
                    {
                        _playersList[currentPlayerNo].Output.ShowMoveError(currentPlayer, "INVALID_FIELD");
                        continue;
                    }

                    if (_game.MakeMove(move) == false)
                    {
                        _playersList[currentPlayerNo].Output.ShowMoveError(currentPlayer, "OCCUPIED_FIELD");
                        continue;
                    }
                    break;
                }
            }

            foreach (var player in _playersList)
            {
                player.Output.ShowBoard(_game.GetBoard());
                if (_game.CheckWinner())
                    player.Output.ShowWinner(_game.GetWinner());
                else
                    player.Output.ShowDraw();
                if (_hotseat) break;
            }
        }
    }
}
