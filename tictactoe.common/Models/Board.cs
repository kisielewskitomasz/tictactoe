﻿using System;
namespace tictactoe
{
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
            if (field < 0 || field > 8)
                return false;
            if (_board[field] != Fields.Empty)
                return false;
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
            return (char[]) _board.Clone();
        }
    }
}
