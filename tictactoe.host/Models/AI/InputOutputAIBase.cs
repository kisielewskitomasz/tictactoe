using System;
namespace tictactoe
{
    public abstract class InputOutputAI : IInput, IOutput
    {
        protected char[] _board;
        protected char _aiPlayer;
        protected Random _rnd;

        protected InputOutputAI()
        {
            _rnd = new Random();
        }

        public virtual int GetMove()
        {
            return -1;
        }

        public void ShowBoard(Board board)
        {
            _board = board.Get();
        }

        public void ShowCurrentPlayer(char currentPlayer)
        {
            _aiPlayer = currentPlayer;
        }

        int GetCurrentTurn()
        {
            int currentTurn = 0;
            foreach (var item in _board)
                if (item != Fields.Empty)
                    currentTurn++;
            return currentTurn;
        }

        public void ShowDraw()
        {
        }

        public void ShowGreeting()
        {
        }

        public void ShowMoveError(char currentPlayer, string codeError)
        {
        }

        public void ShowWinner(char winner)
        {
        }
    }
}
