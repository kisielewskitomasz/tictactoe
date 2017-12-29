using System;
using System.Net;
using System.Net.Sockets;

namespace client
{
    public class NetworkClient
    {
        public TcpClient TcpClient { get => _tcpClient; set => _tcpClient = value; }

        TcpClient _tcpClient;

        public NetworkClient(string adressIp, int port)
        {
            try
            {
                Console.WriteLine($"client connecting to: {adressIp}:{port}");
                TcpClient = new TcpClient(adressIp, port);

                Console.WriteLine("Player 2 connected:");
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
