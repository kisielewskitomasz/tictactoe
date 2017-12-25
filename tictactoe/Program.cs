using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace tictactoe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            NetworkServer networkServer = new NetworkServer("0.0.0.0", 31337);

            List<Player> players = new List<Player>
            {
                //LOCAL PLAY
                //new Player(Fields.X, new InputConsole(), new OutputConsole()),
                //new Player(Fields.O, new InputConsole(), new OutputConsole())
                //NETWORK PLAY
                new Player(Fields.X, new InputConsole(), new OutputConsole()),
                new Player(Fields.O, new InputNetworkServer(networkServer), new OutputNetworkServer(networkServer))
            };
            Harness harness = new Harness(players);
            harness.StartGame();

            networkServer.Stop();
        }
    }
}
