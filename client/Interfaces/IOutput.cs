using System;
namespace client
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
