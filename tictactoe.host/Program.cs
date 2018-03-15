using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace tictactoe
{
    class MainClass
    {
        public static void Main()
        {
            //NetworkServer networkServer = new NetworkServer("0.0.0.0", 31337);

            //InputOutputAI inputOutputAI = new InputOutputAIEasy();
            InputOutputAI inputOutputAI = new InputOutputAIMedium();
            //InputOutputAI inputOutputAI = new InputOutputAIHard();

            //InputConsole inputConsoleCommon = new InputConsole();

            List<Player> players = new List<Player>
            {
                //LOCAL PLAY
                //new Player(Fields.X, inputConsoleCommon, new OutputConsole()),
                //new Player(Fields.O, inputConsoleCommon, new OutputConsole())

                //LOCAL AI PLAY
                new Player(Fields.X, new InputConsole(), new OutputConsole()),
                new Player(Fields.O, inputOutputAI, inputOutputAI)

                //NETWORK PLAY
                //new Player(Fields.X, new InputConsole(), new OutputConsole()),
                //new Player(Fields.O, new InputNetworkServer(networkServer), new OutputNetworkServer(networkServer))
            };
            Harness harness = new Harness(players);
            harness.StartGame();

            //networkServer.Stop();

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
