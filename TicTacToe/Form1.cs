using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        //Game Start (0 - Nope, 1 - Start, 2 - Need Reset)
        private int gameStart = 1;
        private String currentPlayer = Values.EMPTY;
        private int turnNo = -1;

        public static String[,] gameBoard = new String[3,3];



        public Form1()
        {
            InitializeComponent();

            InitializeGame();
            DisableGame();
        }

        private void InitializeGame(){
            r11.Text = r12.Text
                = r21.Text = r22.Text
                = r31.Text = r32.Text
                = r13.Text = r23.Text
                = r33.Text = Values.EMPTY;

            gameBoard[0, 0] = gameBoard[0, 1] = gameBoard[0, 2]
                = gameBoard[1, 0] = gameBoard[1, 1] = gameBoard[1, 2]
                = gameBoard[2, 0] = gameBoard[2, 1] = gameBoard[2, 2]
                = Values.EMPTY;
        }

        private void DisableGame()
        {
            gameStart = 0;
            grpGamePlay.Enabled = false;
            btnReset.Enabled = false;
        }

        private Boolean isSinglePlayer()
        {
            return rbSP.Checked;
        }

        private void promptReset(){
            gameStart = 2;
            grpGamePlay.Enabled = false;
        }

        private void checkWon()
        {
            if (AlgorithmCheck.hasWon(Values.X, gameBoard))
            {
                MessageBox.Show("X has won the game!", "X Won!");
                promptReset();
            }
            else if (AlgorithmCheck.hasWon(Values.O, gameBoard))
            {
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
                //Coming Soon
                //TODO Create AI for SP
                lblInstructions.Text = "Coming Soon...";
            }
            else
            {
                turnNo++;
                if (currentPlayer == Values.X)
                    currentPlayer = Values.O;
                else
                    currentPlayer = Values.X;
                updateTurnDisplay();

                //Check drawn
                if (AlgorithmCheck.hasDrawn(turnNo))
                {
                    MessageBox.Show("This game is a draw!", "Game Drawn");
                    promptReset();
                }
            }
        }

        private void StartGame()
        {
            Random random = new Random();
            int whoStartsFirst = random.Next(2);
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
            InitializeGame();
            DisableGame();
            btnStart.Enabled = true;
            groupSelect.Enabled = true;
            lblInstructions.Text = "Press Start Game to Start";
        }

        private void updateTurnDisplay()
        {
            lblInstructions.Text = "Current Turn: " + currentPlayer + " Turn: " + turnNo;
        }

        private void UpdateMove(int row, int col)
        {
            if (checkValid(row, col))
            {
                gameBoard[row, col] = currentPlayer;
                updateButtons();
                checkWon();
            }
        }

        private void updateButtons()
        {
            r11.Text = gameBoard[0, 0];
            r12.Text = gameBoard[0, 1];
            r13.Text = gameBoard[0, 2];
            r21.Text = gameBoard[1, 0];
            r22.Text = gameBoard[1, 1];
            r23.Text = gameBoard[1, 2];
            r31.Text = gameBoard[2, 0];
            r32.Text = gameBoard[2, 1];
            r33.Text = gameBoard[2, 2];
        }

        private Boolean checkValid(int row, int col){
            if (gameBoard[row,col] != Values.EMPTY){
                MessageBox.Show("Invalid Selection. It is taken up by '" + gameBoard[row,col] + "' Please choose another selection.");
                return false;
            }
            return true;
        }



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
                /*
                lblInstructions.Text = "Single Player Mode Selected. Game Starts in 5 seconds...";
                gameStart = 1;
                btnStart.Enabled = false;
                btnReset.Enabled = true;
                groupSelect.Enabled = false;
                grpGamePlay.Enabled = true;*/
                lblInstructions.Text = "Single Player Mode coming soon. Please select another";
            }
            else
            {
                //Single Player
                lblInstructions.Text = "Multi Player Mode Selected. Getting who starts first";
                gameStart = 1;
                btnStart.Enabled = false;
                groupSelect.Enabled = false;
                btnReset.Enabled = true;
                grpGamePlay.Enabled = true;
                StartGame();
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


    }
}
