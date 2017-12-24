using System;
namespace tictactoe
{
    public class Game
    {
        bool _endOfGame;
        char _currentPlayer;
        char _winner;
        Board _board;

        public Game()
        {
            _board = new Board();
            _currentPlayer = Fields.X;
            _endOfGame = false;
            _winner = Fields.Empty;
        }

        public bool IsFinished()
        {
            return _endOfGame;
        }

        public char GetCurrentPlayer()
        {
            return _currentPlayer;
        }

        public int GetCurrentPlayerNo()
        {
            if (_currentPlayer == Fields.X)
                return 0;
            return 1;
        }

        public char GetWinner()
        {
            return _winner;
        }

        public Board GetBoard()
        {
            return _board;
        }

        public bool MakeMove(int field)
        {
            if (_endOfGame)
                return false;

            if (!(_board.Put(field, _currentPlayer)))
                return false;

            if (CheckWinner())
            {
                _winner = _currentPlayer;
                _endOfGame = true;
                return true;
            }

            if (!(_board.IsMoveAvailable()))
            {
                _winner = Fields.Empty;
                _endOfGame = true;
                return true;
            }

            if (_currentPlayer == Fields.X)
                _currentPlayer = Fields.O;
            else
                _currentPlayer = Fields.X;

            return true;
        }

        public bool CheckWinner()
        {
            int[,] winningFields = {
                { 0, 1, 2 },
                { 3, 4, 5 },
                { 6, 7, 8 },
                { 0, 3, 6 },
                { 1, 4, 7 },
                { 2, 5, 8 },
                { 0, 4, 8 },
                { 2, 4, 6 }
            };

            for (int i = 0; i < 8; i++)
            {
                if (_board.Get()[winningFields[i, 0]] == _board.Get()[winningFields[i, 1]] &&
                    _board.Get()[winningFields[i, 0]] == _board.Get()[winningFields[i, 2]] &&
                    _board.Get()[winningFields[i, 0]] != Fields.Empty)
                    return true;
            }
            return false;
        }
    }
}
