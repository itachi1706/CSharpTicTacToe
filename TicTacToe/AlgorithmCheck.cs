using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class AlgorithmCheck
    {
        private static String[,] gameBoardCheck = null;

        public static Boolean hasWon(String value, String[,] gameBoard)
        {
            Boolean winValue = false;
            gameBoardCheck = gameBoard;
            if (wonVert(value) || wonHorizontal(value) || wonDiagonal(value))
                return true;
            return false;

        }

        private static Boolean wonVert(String value)
        {
            for (int col = 0; col < gameBoardCheck.GetLength(1); col++)
            {
                if (gameBoardCheck[0,col] == value && gameBoardCheck[0,col] == gameBoardCheck[1,col]
                    && gameBoardCheck[1,col] == gameBoardCheck[2,col])
                    return true;
            }
            return false;
        }

        private static Boolean wonHorizontal(String value)
        {
            for (int row = 0; row < gameBoardCheck.GetLength(0); row++)
            {
                if (gameBoardCheck[row, 0] == value && gameBoardCheck[row, 0] == gameBoardCheck[row, 1]
                    && gameBoardCheck[row, 2] == gameBoardCheck[row, 1])
                    return true;
            }
            return false;
        }

        private static Boolean wonDiagonal(String value)
        {
            return ((gameBoardCheck[0,0] == gameBoardCheck[1,1] && gameBoardCheck[1,1] == gameBoardCheck[2,2])
                || (gameBoardCheck[0,2] == gameBoardCheck[1,1] && gameBoardCheck[1,1] == gameBoardCheck[2,0]))
                && gameBoardCheck[1,1] == value;
        }
    }
}
