using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JR.Utils.GUI.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        //Game Start (0 - Nope, 1 - Start, 2 - Need Reset)
        private static int gameStart = 1;
        private static String currentPlayer = Values.EMPTY;
        private static int turnNo = -1;
        private static int lastRow = -1, lastCol = -1;

        public static String[,] gameBoard = new String[3,3];



        public Form1()
        {
            InitializeComponent();
            LoggingClass.initLog();

            MaximizeBox = false;

            InitializeGame();
            DisableGame();
        }

        private void InitializeGame(){
            LoggingClass.logInfo("SYSTEM", "Init Game");
            r11.Text = r12.Text
                = r21.Text = r22.Text
                = r31.Text = r32.Text
                = r13.Text = r23.Text
                = r33.Text = Values.EMPTY;

            gameBoard[0, 0] = gameBoard[0, 1] = gameBoard[0, 2]
                = gameBoard[1, 0] = gameBoard[1, 1] = gameBoard[1, 2]
                = gameBoard[2, 0] = gameBoard[2, 1] = gameBoard[2, 2]
                = Values.EMPTY;
            LoggingClass.logInfo("SYSTEM", "Init Complete");
        }

        private void DisableGame()
        {
            LoggingClass.logInfo("SYSTEM", "Game Area Disabled");
            gameStart = 0;
            grpGamePlay.Enabled = false;
            btnReset.Enabled = false;
            newGameToolStripMenuItem.Enabled = false;
        }

        private Boolean isSinglePlayer()
        {
            return rbSP.Checked;
        }

        private void promptReset(){
            LoggingClass.logInfo("SYSTEM", "Init Reset Prompt");
            gameStart = 2;
            grpGamePlay.Enabled = false;
        }

        private void checkWon()
        {
            if (AlgorithmCheck.hasWon(Values.X, gameBoard))
            {
                LoggingClass.logInfo("GAME-WIN", "X WON");
                MessageBox.Show("X has won the game!", "X Won!");
                promptReset();
            }
            else if (AlgorithmCheck.hasWon(Values.O, gameBoard))
            {
                LoggingClass.logInfo("GAME-WIN", "O WON");
                MessageBox.Show("O has won the game!", "O Won!");
                promptReset();
            }

            //If not won, update
            if (gameStart == 1)
            {
                NextTurn();
            }
        }

        private void NextTurn()
        {
            if (isSinglePlayer())
            {
                LoggingClass.logInfo("GAME", "Single Player Mode");
                turnNo++;
                LoggingClass.logInfo("GAME", "Incremented Turn No");
                if (currentPlayer == Values.X)
                {
                    //AI's Turn
                    currentPlayer = Values.AI;
                    updateTurnDisplay();
                    grpGamePlay.Enabled = false;
                    ComputerAI.determineNextMove(gameBoard, lastRow, lastCol, turnNo);
                    UpdateAIRefreshes();
                }
                else
                {
                    currentPlayer = Values.X;
                    grpGamePlay.Enabled = true;
                    updateTurnDisplay();
                }

                //Check drawn
                if (AlgorithmCheck.hasDrawn(turnNo))
                {
                    if (gameStart == 2)
                    {
                        LoggingClass.logInfo("SYSTEM", "Already prompted Draw Message");
                    }
                    else
                    {
                        MessageBox.Show("This game is a draw!", "Game Drawn");
                        LoggingClass.logInfo("SYSTEM", "Game Drawn");
                        promptReset();
                    }
                }
                
            }
            else
            {
                LoggingClass.logInfo("GAME", "Multiplayer Mode");
                turnNo++;
                LoggingClass.logInfo("GAME", "Incremented Turn No");
                if (currentPlayer == Values.X)
                    currentPlayer = Values.O;
                else
                    currentPlayer = Values.X;
                updateTurnDisplay();

                //Check drawn
                if (AlgorithmCheck.hasDrawn(turnNo))
                {
                    MessageBox.Show("This game is a draw!", "Game Drawn");
                    LoggingClass.logInfo("SYSTEM", "Game Drawn");
                    promptReset();
                }
            }
        }

        private void StartGameSP()
        {
            LoggingClass.logInfo("SYSTEM", "Game Start (SP)");
            lblInstructions.Text = "Player Starts First! Turn: 0";
            currentPlayer = Values.X;
            turnNo = 0;
        }

        private void StartGameMultiplayer()
        {
            LoggingClass.logInfo("SYSTEM", "Game Start (MP)");
            Random random = new Random();
            int whoStartsFirst = random.Next(2);
            LoggingClass.logInfo("Random", "Rolled " + whoStartsFirst);
            //MessageBox.Show(whoStartsFirst + "");
            if (whoStartsFirst == 1)
            {
                //X
                lblInstructions.Text = "X Starts First! Turn: 0";
                currentPlayer = Values.X;
            }
            else
            {
                //O
                lblInstructions.Text = "O Starts First! Turn: 0";
                currentPlayer = Values.O;
            }
            turnNo = 0;

        }

        private void ResetGame()
        {
            LoggingClass.logInfo("SYSTEM", "Game Reset");
            InitializeGame();
            DisableGame();
            btnStart.Enabled = true;
            groupSelect.Enabled = true;
            lblInstructions.Text = "Press Start Game to Start";
        }

        private void updateTurnDisplay()
        {
            if (isSinglePlayer())
            {
                if (currentPlayer == Values.AI)
                    lblInstructions.Text = "Current Turn: " + currentPlayer + " Turn: " + turnNo;
                else
                    lblInstructions.Text = "Current Turn: Player   Turn: " + turnNo;
            }
            else
            {
                lblInstructions.Text = "Current Turn: " + currentPlayer + " Turn: " + turnNo;
            }
        }

        private void UpdateMove(int row, int col)
        {
            if (checkValid(row, col))
            {
                LoggingClass.logInfo("Player Move", "Turn " + turnNo + ": Placed at " + row + ":" + col);
                gameBoard[row, col] = currentPlayer;
                updateButtons();
                lastCol = col;
                lastRow = row;
                checkWon();
            }
        }

        public static void UpdateAIMove(int row, int col)
        {
            LoggingClass.logInfo("AI Move", "Turn " + turnNo + ": Placed at " + row + ":" + col);
            gameBoard[row, col] = Values.O;
        }

        private void UpdateAIRefreshes()
        {
            LoggingClass.logInfo("Refresh AI", "Refreshing AI");
            updateButtons();
            checkWon();
        }

        private void updateButtons()
        {
            LoggingClass.logInfo("Update Button", "Updating Button");
            r11.Text = gameBoard[0, 0];
            r12.Text = gameBoard[0, 1];
            r13.Text = gameBoard[0, 2];
            r21.Text = gameBoard[1, 0];
            r22.Text = gameBoard[1, 1];
            r23.Text = gameBoard[1, 2];
            r31.Text = gameBoard[2, 0];
            r32.Text = gameBoard[2, 1];
            r33.Text = gameBoard[2, 2];
            LoggingClass.logInfo("Update Button", "Update Complete");
        }

        private Boolean checkValid(int row, int col){
            if (gameBoard[row,col] != Values.EMPTY){
                MessageBox.Show("Invalid Selection. It is taken up by '" + gameBoard[row,col] + "' Please choose another selection.");
                return false;
            }
            return true;
        }

        public static void throwError(String errorMsg)
        {
            MessageBox.Show(errorMsg, "ERROR");
            LoggingClass.logError("ERROR", errorMsg);
        }

        /*
         * Debug Area
         */
        


        /*
         * Listeners
         */

        //Controls 

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isSinglePlayer())
            {
                //Single Player
                lblInstructions.Text = "Single Player Mode Selected. Game Starts in 5 seconds...";
                gameStart = 1;
                btnStart.Enabled = false;
                btnReset.Enabled = true;
                newGameToolStripMenuItem.Enabled = true;
                groupSelect.Enabled = false;
                grpGamePlay.Enabled = true;
                StartGameSP();
                //lblInstructions.Text = "Single Player Mode coming soon. Please select another";
            }
            else
            {
                //Multi Player
                lblInstructions.Text = "Multi Player Mode Selected. Getting who starts first";
                gameStart = 1;
                btnStart.Enabled = false;
                groupSelect.Enabled = false;
                btnReset.Enabled = true;
                newGameToolStripMenuItem.Enabled = true;
                grpGamePlay.Enabled = true;
                StartGameMultiplayer();
            }
        }

        //Tic Tac Toe Buttons
        private void r11_Click(object sender, EventArgs e)
        {
            UpdateMove(0, 0);
        }

        private void r12_Click(object sender, EventArgs e)
        {
            UpdateMove(0, 1);
        }

        private void r13_Click(object sender, EventArgs e)
        {
            UpdateMove(0, 2);
        }

        private void r21_Click(object sender, EventArgs e)
        {
            UpdateMove(1, 0);
        }

        private void r22_Click(object sender, EventArgs e)
        {
            UpdateMove(1, 1);
        }

        private void r23_Click(object sender, EventArgs e)
        {
            UpdateMove(1, 2);
        }

        private void r31_Click(object sender, EventArgs e)
        {
            UpdateMove(2, 0);
        }

        private void r32_Click(object sender, EventArgs e)
        {
            UpdateMove(2, 1);
        }

        private void r33_Click(object sender, EventArgs e)
        {
            UpdateMove(2, 2);
        }

        private void viewGameLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList logList = LoggingClass.getLogList();
            String msg = "";
            foreach (string log in logList){
                msg += log + "\n";
            }
            FlexibleMessageBox.Show(msg, "Log");
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
