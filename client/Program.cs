using System;

namespace client
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            NetworkClient networkClient = new NetworkClient("127.0.0.1", 31337);
                


            networkClient.Stop();
        }
    }
}
