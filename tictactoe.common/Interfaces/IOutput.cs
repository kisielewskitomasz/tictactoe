using System;
using tictactoe;

namespace tictactoe
{
    public interface IOutput
    {
        void ShowGreeting();

        void ShowBoard(Board board);

        void ShowCurrentPlayer(char currentPlayer);

        void ShowMoveError(char currentPlayer, string codeError);

        void ShowWinner(char winner);

        void ShowDraw();
    }
}
