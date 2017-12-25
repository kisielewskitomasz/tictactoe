using System;
using System.Text;

namespace tictactoe
{
    public class InputNetworkClient : IInput
    {
        NetworkClient _network;
        InputConsole _inputConsole;

        public InputNetworkClient(NetworkClient network)
        {
            _network = network;
            _inputConsole = new InputConsole();
        }

        public int GetMove()
        {
            int move = _inputConsole.GetMove();
            byte[] buff = new byte[16];

            _network.TcpClient.Client.Send(Encoding.UTF8.GetBytes("m" + move));
            Console.WriteLine($"send move: {move}");
            return move;
        }
    }
}
