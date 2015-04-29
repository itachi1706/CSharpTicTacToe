using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class ComputerAI
    {

        //AI IS ALWAYS O

        /**
         * Gameboard
         * 0 1 2
         * 3 4 5
         * 6 7 8
         */

        public static void determineNextMove(string[,] gameBoard, int lastRow, int lastCol, int turn)
        {
            //Check if first turn and is middle
            if (turn == 1)
            {
                firstMove(gameBoard, lastRow, lastCol);
            }
            else
            {
                //See if AI can win
            }
        }

        private static void checkForPossibleAIWin(string[,] gameBoard)
        {
            if (gameBoard[0, 0] == Values.O)
            {
                //Possible Game Moves (1,2,3,4,6,8)
                //Possible Row 1 or Col 1 or Diag 1 win
                if (gameBoard[0, 1] == Values.O && isValidMove(gameBoard, 2)) makeMove(2);
                else if (gameBoard[0, 2] == Values.O && isValidMove(gameBoard, 1)) makeMove(1);
                else if (gameBoard[1, 0] == Values.O && isValidMove(gameBoard, 6)) makeMove(6);
                else if (gameBoard[2, 0] == Values.O && isValidMove(gameBoard, 3)) makeMove(3);
                else if (gameBoard[1, 1] == Values.O && isValidMove(gameBoard, 8)) makeMove(8);
                else if (gameBoard[2, 2] == Values.O && isValidMove(gameBoard, 4)) makeMove(4);
            }
            else if (gameBoard[0, 1] == Values.O)
            {
                //Possible Game Moves (0, 2, 4, 7)
                if (gameBoard[0, 2] == Values.O && isValidMove(gameBoard, 0)) makeMove(0);
                else if (gameBoard[0, 0] == Values.O && isValidMove(gameBoard, 2)) makeMove(2);
                else if (gameBoard[2, 1] == Values.O && isValidMove(gameBoard, 4)) makeMove(4);
                else if (gameBoard[1, 1] == Values.O && isValidMove(gameBoard, 7)) makeMove(7);
            }
            else if (gameBoard[0, 2] == Values.O)
            {
                //Possible Game Moves (0,1,4,5,6,8)
                if (gameBoard[0, 1] == Values.O && isValidMove(gameBoard, 0)) makeMove(0);
                else if (gameBoard[0, 0] == Values.O && isValidMove(gameBoard, 1)) makeMove(1);
                else if (gameBoard[2, 0] == Values.O && isValidMove(gameBoard, 4)) makeMove(4);
                else if (gameBoard[2, 2] == Values.O && isValidMove(gameBoard, 5)) makeMove(5);
                else if (gameBoard[1, 1] == Values.O && isValidMove(gameBoard, 6)) makeMove(6);
                else if (gameBoard[1, 2] == Values.O && isValidMove(gameBoard, 8)) makeMove(8);
            }
            else if (gameBoard[1, 0] == Values.O)
            {

            }
            else if (gameBoard[1, 1] == Values.O)
            {

            }
            else if (gameBoard[1, 2] == Values.O)
            {

            }
            else if (gameBoard[2, 1] == Values.O)
            {

            }
            else if (gameBoard[2, 2] == Values.O)
            {
                
            }
        }

        private static void firstMove(string[,] gameBoard, int lastRow, int lastCol)
        {
            //Get Current Move
            int moveMade = getGameBoardNum(lastRow, lastCol);
            //Check if middle
            if (moveMade == 4 && gameBoard[1, 1] == Values.X)
            {
                while (true)
                {
                    //Randomly select a corner
                    Random random = new Random();
                    int nextMove = random.Next(9);
                    if ((nextMove == 0 || nextMove == 2 || nextMove == 6 || nextMove == 8)
                        && isValidMove(gameBoard, nextMove))
                    {
                        makeMove(nextMove);
                        return;
                    }
                }
            }
                        
            //Check corner
            if ((moveMade == 0 || moveMade == 2 || moveMade == 6 || moveMade == 8)
                && gameBoard[lastRow, lastCol] == Values.X)
            {
                //Select center
                if (isValidMove(gameBoard, 4))
                {
                    makeMove(4);
                    return;
                }

            }

            //Check side
            if ((moveMade == 1 || moveMade == 3 || moveMade == 5 || moveMade == 7)
                && gameBoard[lastRow, lastCol] == Values.X)
            {
                //Select other side
                int plannedMove = -1;
                switch (moveMade){
                    case 1: plannedMove = 7; break;
                    case 3: plannedMove = 5; break;
                    case 5: plannedMove = 3; break;
                    case 7: plannedMove = 1; break;
                }

                if (isValidMove(gameBoard, plannedMove))
                {
                    makeMove(plannedMove);
                    return;
                }
            }

            //Error
            Form1.throwError("An error occured trying to make first move. Please contact dev.");
        }

        private static int getGameBoardNum(int lastRow, int lastCol)
        {
            switch (lastRow)
            {
                case 0:
                    switch (lastCol)
                    {
                        case 0: return 0;
                        case 1: return 1;
                        case 2: return 2;
                    }
                    break;
                case 1:
                    switch (lastCol)
                    {
                        case 0: return 3;
                        case 1: return 4;
                        case 2: return 5;
                    }
                    break;
                case 2:
                    switch (lastCol)
                    {
                        case 0: return 6;
                        case 1: return 7;
                        case 2: return 8;
                    }
                    break;
            }
            return -1;
        }

        private static Boolean isValidMove(string[,] gameBoard, int nextMove)
        {
            int row = getRow(nextMove);
            int col = getCol(nextMove);
            if (row == -1 || col == -1)
            {
                return false;
            }
            return gameBoard[row, col] == Values.EMPTY;
        }

        private static int getRow(int nextMove)
        {
            switch (nextMove)
            {
                case 0:
                case 1:
                case 2: return 0;
                case 3:
                case 4:
                case 5: return 1;
                case 6:
                case 7:
                case 8: return 2;
            }
            return -1;
        }

        private static int getCol(int nextMove)
        {
            switch (nextMove)
            {
                case 0:
                case 3:
                case 6: return 0;
                case 1:
                case 4:
                case 7: return 1;
                case 2:
                case 5:
                case 8: return 2;
            }
            return -1;
        }


        //Make a move
        public static void makeMove(int nextMove)
        {
            switch (nextMove)
            {
                case 0: Form1.UpdateAI(0, 0); break;
                case 1: Form1.UpdateAI(0, 1); break;
                case 2: Form1.UpdateAI(0, 2); break;
                case 3: Form1.UpdateAI(1, 0); break;
                case 4: Form1.UpdateAI(1, 1); break;
                case 5: Form1.UpdateAI(1, 2); break;
                case 6: Form1.UpdateAI(2, 0); break;
                case 7: Form1.UpdateAI(2, 1); break;
                case 8: Form1.UpdateAI(2, 2); break;
            }
        }
    }
}
