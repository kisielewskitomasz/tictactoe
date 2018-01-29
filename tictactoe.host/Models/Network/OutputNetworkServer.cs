using System;
using System.Text;

namespace tictactoe
{
    public class OutputNetworkServer : IOutput
    {
        NetworkServer _network;

        public OutputNetworkServer(NetworkServer network)
        {
            _network = network;
        }

        public void ShowBoard(Board board)
        {
            _network.TcpClient.Client.Send(Encoding.UTF8.GetBytes("B" + new string(board.Get())));
        }

        public void ShowCurrentPlayer(char currentPlayer)
        {
            _network.TcpClient.Client.Send(Encoding.UTF8.GetBytes("C" + currentPlayer));
        }

        public void ShowDraw()
        {
            _network.TcpClient.Client.Send(Encoding.UTF8.GetBytes("D"));
        }

        public void ShowMoveError(char currentPlayer, string codeError)
        {
            _network.TcpClient.Client.Send(Encoding.UTF8.GetBytes("E" + currentPlayer + codeError));
        }

        public void ShowGreeting()
        {
            _network.TcpClient.Client.Send(Encoding.UTF8.GetBytes("G"));
        }

        public void ShowWinner(char winner)
        {
            _network.TcpClient.Client.Send(Encoding.UTF8.GetBytes("W" + winner));
        }
    }
}
