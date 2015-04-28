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
                MessageBox.Show("X has won the game!");
                promptReset();
            }
            else if (AlgorithmCheck.hasWon(Values.O, gameBoard))
            {
                MessageBox.Show("Y has won the game!");
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
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

        private void r11_Click(object sender, EventArgs e)
        {
            if (checkValid(0,0)){
                r11.Text = currentPlayer;
                gameBoard[0,0] = currentPlayer;
                checkWon();
            }
        }

        private void r12_Click(object sender, EventArgs e)
        {
            if (checkValid(0,1)){
                r12.Text = currentPlayer;
                gameBoard[0,1] = currentPlayer;
                checkWon();
            }
        }

        private void r13_Click(object sender, EventArgs e)
        {
            if (checkValid(0,2)){
                r13.Text = currentPlayer;
                gameBoard[0,2] = currentPlayer;
                checkWon();
            }
        }

        private void r21_Click(object sender, EventArgs e)
        {
            if (checkValid(1,0)){
                r21.Text = currentPlayer;
                gameBoard[1,0] = currentPlayer;
                checkWon();
            }
        }

        private void r22_Click(object sender, EventArgs e)
        {
            if (checkValid(1,1)){
                r22.Text = currentPlayer;
                gameBoard[1,1] = currentPlayer;
                checkWon();
            }
        }

        private void r23_Click(object sender, EventArgs e)
        {
            if (checkValid(1,2)){
                r23.Text = currentPlayer;
                gameBoard[1,2] = currentPlayer;
                checkWon();
            }
        }

        private void r31_Click(object sender, EventArgs e)
        {
            if (checkValid(2,0)){
                r31.Text = currentPlayer;
                gameBoard[2,0] = currentPlayer;
                checkWon();
            }
        }

        private void r32_Click(object sender, EventArgs e)
        {
            if (checkValid(2,1)){
                r32.Text = currentPlayer;
                gameBoard[2,1] = currentPlayer;
                checkWon();
            }
            
        }

        private void r33_Click(object sender, EventArgs e)
        {
            if (checkValid(2,2)){
                r33.Text = currentPlayer;
                gameBoard[2,2] = currentPlayer;
                checkWon();
            }
        }

        private Boolean checkValid(int row, int col){
            if (gameBoard[row,col] != Values.EMPTY){
                MessageBox.Show("Invalid Selection. It is taken up by '" + gameBoard[row,col] + "' Please choose another selection.");
                return false;
            }
            return true;
        }
    }
}
