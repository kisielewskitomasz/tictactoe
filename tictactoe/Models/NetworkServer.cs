using System;
using System.Net;
using System.Net.Sockets;

namespace tictactoe
{
    public class NetworkServer
    {
        public TcpClient TcpClient { get => _tcpClient; set => _tcpClient = value; }

        IPAddress _ipAddress;
        TcpListener _tcpListener;
        TcpClient _tcpClient;

        public NetworkServer(string adressIp, int port)
        {
            _ipAddress = IPAddress.Parse(adressIp);
            try
            {
                _tcpListener = new TcpListener(_ipAddress, port);
                _tcpListener.Start(1);
                Console.WriteLine($"Waiting for connection: {_ipAddress}:{port}");
                _tcpClient = _tcpListener.AcceptTcpClient();
                Console.WriteLine("Player 2 connected:");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Stop()
        {
            _tcpListener.Stop();
            _tcpClient.Close();
            _tcpClient.Dispose();
        }
    }
}
