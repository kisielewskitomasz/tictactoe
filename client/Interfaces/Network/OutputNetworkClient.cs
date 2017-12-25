using System;
using System.Text;

namespace tictactoe
{
    public class OutputNetworkClient : IOutput
    {
        NetworkClient _network;
        OutputConsole _outputConsole;

        public OutputNetworkClient(NetworkClient network)
        {
            _network = network;
            _outputConsole = new OutputConsole();
        }

        public void ShowBoard(Board board)
        {
            int bytes;
            byte[] buff = new byte[16];
            bytes = _network.TcpClient.Client.Receive(buff); // in future - add errors handling
            char[] fields = new char[9];
            Array.Copy(buff, 1, fields, 0, 9);
            Board sboard = new Board(fields);

            //_outputConsole.ShowBoard()
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
