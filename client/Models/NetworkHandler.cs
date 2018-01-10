using System;
using System.Text;

namespace client
{
    public class NetworkHandler
    {
        Player _player;
        NetworkClient _networkClient;

        public NetworkHandler(Player player, NetworkClient networkClient)
        {
            _player = player;
            _networkClient = networkClient;
        }

        public void HandleRequest()
        {
            bool mainLoop = true;
            while (mainLoop)
            {
                byte[] buf = new byte[1];
                int bytes = _networkClient.TcpClient.Client.Receive(buf, 1, System.Net.Sockets.SocketFlags.None);
                char recivedOperation = Encoding.UTF8.GetChars(buf)[0];

                switch (recivedOperation)
                {
                    case 'M':
                        {
                            int move = _player.Input.GetMove();
                            _networkClient.TcpClient.Client.Send(Encoding.UTF8.GetBytes("m" + move));
                            break;
                        }
                    case 'B':
                        {
                            byte[] buff = new byte[9];
                            int bytess = _networkClient.TcpClient.Client.Receive(buff, 9, System.Net.Sockets.SocketFlags.None);
                            char[] fields = new char[9];
                            Array.Copy(buff, 0, fields, 0, 9);
                            Board board = new Board(fields);
                            _player.Output.ShowBoard(board);
                            break;
                        }
                    case 'C':
                        {
                            byte[] buff = new byte[1];
                            int bytess = _networkClient.TcpClient.Client.Receive(buff, 1, System.Net.Sockets.SocketFlags.None);
                            char[] currentPlayer = new char[1];
                            Array.Copy(buff, 0, currentPlayer, 0, 1);
                            _player.Output.ShowCurrentPlayer(currentPlayer[0]);
                            break;
                        }
                    case 'D':
                        {
                            _player.Output.ShowDraw();
                            break;
                        }
                    case 'E':
                        {
                            byte[] buff = new byte[1];
                            int bytess = _networkClient.TcpClient.Client.Receive(buff, 1, System.Net.Sockets.SocketFlags.None);
                            byte[] buff2 = new byte[3];
                            int bytess2 = _networkClient.TcpClient.Client.Receive(buff2, 3, System.Net.Sockets.SocketFlags.None);
                            char[] currentPlayer = new char[1];
                            char[] errorCode = new char[3];
                            Array.Copy(buff, 0, currentPlayer, 0, 1);
                            Array.Copy(buff2, 0, errorCode, 0, 3);
                            string errorMessage = new string(errorCode);
                            _player.Output.ShowMoveError(currentPlayer[0], errorMessage);
                            break;
                        }
                    case 'G':
                        {
                            _player.Output.ShowGreeting();
                            break;
                        }
                    case 'W':
                        {
                            byte[] buff = new byte[1];
                            int bytess = _networkClient.TcpClient.Client.Receive(buff, 1, System.Net.Sockets.SocketFlags.None);
                            char[] winner = new char[1];
                            Array.Copy(buff, 0, winner, 0, 1);
                            _player.Output.ShowWinner(winner[0]);

                            mainLoop = false;

                            break;
                        }
                }
            }
        }
    }
}
