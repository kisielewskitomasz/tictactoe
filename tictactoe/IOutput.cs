using System;
namespace tictactoe
{
    public interface IOutput
    {
        void ShowWelcome();

        void ShowBoard(Board board);

        void ShowCurrentPlayer(char currentPlayer);

        void ShowMoveError(char currentPlayer, string codeError);

        void ShowWinner(char winner);

        void ShowDraw();
    }
}
