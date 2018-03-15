using System;
namespace tictactoe
{
    public class InputOutputAIHard : InputOutputAI
    {
        public override int GetMove()
        {

            //#TODO: implement minimax algoritm
            //int[,] weightFields = {
            //    {0, 3}, {1, 2}, {2, 3},
            //    {3, 2}, {4, 4}, {5, 2}, 
            //    {6, 3}, {7, 2}, {8, 3}
            //};

            //int[] weightFields = {
            //    3, 2, 3,
            //    2, 4, 2,
            //    3, 2, 3
            //};

            //int currentWeight = 0;

            //for (int i = 0; i < _board.Length; i++)
            //{
            //    if (_board[i] != Fields.Empty)
            //        weightFields[i] = 0;

            //    currentWeight += weightFields[i]
            //}
                //if ((_board[weightFields[i, 0]] == _aiPlayer) &&
                    //(_board[weightFields[i, 2]] == Fields.Empty))
                    //return weightFields[i, 2];
            

            return _rnd.Next(0, 9);
        }
    }
}
