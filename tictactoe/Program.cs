using System;
using System.Collections.Generic;

namespace tictactoe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Game game = new Game();

            List<IInput> inputs = new List<IInput>
            {
                new InputConsole(),
                new InputConsole()
            };
            List<IOutput> outputs = new List<IOutput>
            {
                new OutputConsole(),
                new OutputConsole()

            };

            Harness harness = new Harness(inputs, outputs);
            harness.StartGame();
        }
    }
}
