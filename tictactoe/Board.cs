using System;
namespace tictactoe
{
    public struct Fields
    {
        public const char Empty = ' ';
        public const char X = 'X';
        public const char O = 'O';
    }

    public class Board
    {
        protected char[] _board;
        
        public Board()
        {
            _board = new char[9];
            for (int i = 0; i < _board.Length; i++)
            {
                _board[i] = Fields.Empty;
            }
        }

        public Board(char[] fields)
        {
            _board = fields;
        }

        public bool Put(int field, char sign)
        {
            Console.WriteLine($"put: checking 0 <= {field} <= 8 ");
            if (field < 0 || field > 8)
                return false;
            Console.WriteLine($"check if {_board[field]} is {Fields.Empty}");
            if (_board[field] != Fields.Empty)
                return false;
            Console.WriteLine($"check sign: {sign}");
            if (sign != Fields.X && sign != Fields.O)
                return false;
            
            _board[field] = sign;
            return true;
        }

        public bool IsMoveAvailable()
        {
            foreach (var item in _board)
            {
                if (item == Fields.Empty)
                    return true;
            }

            return false;
        }

        public char[] Get()
        {
            return _board;
        }

        public void Print()
        {
            Console.WriteLine($" {_board[0]} | {_board[1]} | {_board[2]} ");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($" {_board[3]} | {_board[4]} | {_board[5]} ");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($" {_board[6]} | {_board[7]} | {_board[8]} ");
        }
    }
}
