using System;
using System.Text;

namespace client
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Player player = new Player(Fields.O, new InputConsole(), new OutputConsole());
            NetworkClient networkClient = new NetworkClient("127.0.0.1", 31337);
            NetworkHandler networkHandler = new NetworkHandler(player, networkClient);

            networkHandler.HandleRequest();
            networkClient.Stop();
        }
    }
}
