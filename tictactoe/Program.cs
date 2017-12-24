using System;

namespace tictactoe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Game game = new Game();

            InputConsole inputConsolePlayerFirst = new InputConsole();
            InputConsole inputConsolePlayerSecond = new InputConsole();

            OutputConsole outputConsole = new OutputConsole();

            Harness harness = new Harness(outputConsole, inputConsolePlayerFirst, inputConsolePlayerSecond);
            harness.StartGame();
        }
    }
}
