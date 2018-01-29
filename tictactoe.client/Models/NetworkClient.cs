using System;
using System.Net.Sockets;
using System.Threading;

namespace client
{
    public class NetworkClient
    {
        public TcpClient TcpClient { get => _tcpClient; set => _tcpClient = value; }

        TcpClient _tcpClient;

        public NetworkClient(string serverAdressIp, int port)
        {
            try
            {
                Console.WriteLine($"client connecting to: {serverAdressIp}:{port}");

                _tcpClient = new TcpClient(serverAdressIp, port);

                Console.WriteLine("connected as player 2!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


        public void Stop()
        {
            _tcpClient.Close();
            _tcpClient.Dispose();
        }
    }
}
