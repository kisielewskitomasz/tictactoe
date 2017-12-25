using System;
using System.Text;

namespace tictactoe
{
    public class InputNetworkServer : IInput
    {
        NetworkServer _network;

        public InputNetworkServer(NetworkServer network)
        {
            _network = network;
        }

        public int GetMove()
        {
            int move;
            int bytes;
            byte[] buff = new byte[16];
            _network.TcpClient.Client.Send(Encoding.UTF8.GetBytes("M"));
            bytes = _network.TcpClient.Client.Receive(buff); // in future - add errors handling
            move = int.Parse(buff[1].ToString());
            move -= 48;
            // #TODO check if move is in 0-9
            return move;
        }
    }
}
