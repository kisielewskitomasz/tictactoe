using System;
namespace tictactoe
{
    public class InputOutputAIMedium : InputOutputAI
    {
        int GetCurrentTurn()
        {
            int currentTurn = 0;
            foreach (var item in _board)
                if (item != Fields.Empty)
                    currentTurn++;
            return currentTurn;
        }

        public override int GetMove()
        {
            int[,] twoInRowFields = {
                {0, 1, 2},   /* 1, --  */ 
                {1, 2, 0},   /* 1,  -- */
                {0, 2, 1},   /* 1, - - */
                {3, 4, 5},   /* 2, --  */
                {4, 5, 3},   /* 2,  -- */
                {3, 5, 4},   /* 2, - - */
                {6, 7, 8},   /* 3, --  */
                {7, 8, 6},   /* 3,  -- */
                {6, 8, 7},   /* 3, - - */
                {0, 3, 6},   /* 1. ||  */
                {3, 6, 0},   /* 1.  || */
                {0, 6, 3},   /* 1. | | */
                {1, 4, 7},   /* 2. ||  */
                {4, 7, 1},   /* 2.  || */
                {1, 7, 4},   /* 2. | | */
                {2, 5, 8},   /* 3. ||  */
                {5, 8, 2},   /* 3.  || */
                {2, 8, 5},   /* 3. | | */
                {0, 4, 8},   /* 1; \\  */
                {8, 4, 0},   /* 2;  \\ */
                {0, 8, 4},   /* 3; \ \ */
                {2, 4, 6},   /* 1; \\  */
                {4, 6, 2},   /* 2;  \\ */
                {2, 6, 4}    /* 3; \ \ */
            };

            if (GetCurrentTurn() < 3)
                return _rnd.Next(0, 9);

            for (int i = 0; i <= 23; i++)
            {
                if ((_board[twoInRowFields[i, 0]] == _aiPlayer) &&
                    (_board[twoInRowFields[i, 1]] == _aiPlayer) &&
                    (_board[twoInRowFields[i, 2]] == Fields.Empty))
                    return twoInRowFields[i, 2];
            }

            return _rnd.Next(0, 9);
        }
    }
}
