using System;

namespace client
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Player player = new Player(Fields.O, new InputConsole(), new OutputConsole());
            NetworkClient networkClient = new NetworkClient("10.211.55.5", 31337);
            NetworkHandler networkHandler = new NetworkHandler(player, networkClient);

            networkHandler.HandleRequest();
            networkClient.Stop();
        }
    }
}
