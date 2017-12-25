using System;
using System.Net;
using System.Net.Sockets;

namespace tictactoe
{
    public class NetworkClient
    {
        public IPAddress IpAddress { get => _ipAddress; set => _ipAddress = value; }
        public TcpClient TcpClient { get => _tcpClient; set => _tcpClient = value; }
        public Socket SocketOpen { get => _socketOpen; set => _socketOpen = value; }

        IPAddress _ipAddress;
        TcpClient _tcpClient;
        Socket _socketOpen;

        public NetworkClient(string adressIp, int port)
        {
            IpAddress = IPAddress.Parse(adressIp);
            try
            {
                Console.WriteLine($"client connecting to: {IpAddress}:{port}");
                TcpClient = new TcpClient(adressIp, port);

                //Console.WriteLine("Player 2 connected:");
                //TcpListener.Stop();
                //SocketOpen.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
