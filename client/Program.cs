using System;

namespace client
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const string ip = "127.0.0.1";

            Player player = new Player(Fields.O, new InputConsole(), new OutputConsole());
            NetworkClient networkClient = new NetworkClient(ip, 31337);
            NetworkHandler networkHandler = new NetworkHandler(player, networkClient);

            networkHandler.HandleRequest();
            networkClient.Stop();
        }
    }
}
