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
            byte[] buff = new byte[16];
            _network.TcpClient.Client.Send(Encoding.UTF8.GetBytes("M"));
            int bytes = _network.TcpClient.Client.Receive(buff); // in future - add errors handling
            int move = -1;
            if (!(int.TryParse(buff[1].ToString(), out move)))
                return -1;
            move -= 48;
            if (move >= 0 && move <= 8)
                return move;
            return -1;
        }
    }
}
