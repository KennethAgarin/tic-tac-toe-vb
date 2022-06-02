using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Kenneth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Tic Tac Toe is an activity for the subject Object Oriented Programming by Kenneth Agarin", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        String[] gameBoard = new string[9];
        int currentturn = 0;

        public String returnSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        public void checkForWinner()
        {
            for (int i = 0; i < 8; i++)
            {
                String combination = "";

                switch (i)
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        break;
                    case 1:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        break;
                    case 2:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        break;
                    case 3:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        break;
                    case 4:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        break;
                    case 5:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        break;
                    case 6:
                        combination = gameBoard[1] + gameBoard[4] + gameBoard[7];
                        break;
                    case 7:
                        combination = gameBoard[2] + gameBoard[5] + gameBoard[8];
                        break;
                }

                if (combination.Equals("OOO"))
                {
                    reset();
                    MessageBox.Show("Player O has won the game!", "You are a Winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    O_win.Text = (Int32.Parse(O_win.Text) + 1).ToString();
                }
                else if (combination.Equals("XXX"))
                {
                    reset();
                    MessageBox.Show("Player X has won the game!", "You are a Winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    X_win.Text = (Int32.Parse(X_win.Text) + 1).ToString();

                }
                checkDraw();
            }
        }


        public void reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            gameBoard = new string[9];
            currentturn = 0;

        }

        public void checkDraw()
        {
            int counter = 0;
            for (int i = 0; i < gameBoard.Length; i++)
            {
                if (gameBoard[i] != null) { counter++; }

                if (counter == 9)
                {
                    reset();
                    MessageBox.Show("You're both good. That's a Draw!", "Oops. No winner this round", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[0] = returnSymbol(currentturn);
            button1.Text = gameBoard[0];
            checkForWinner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[1] = returnSymbol(currentturn);
            button2.Text = gameBoard[1];
            checkForWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[2] = returnSymbol(currentturn);
            button3.Text = gameBoard[2];
            checkForWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[3] = returnSymbol(currentturn);
            button4.Text = gameBoard[3];
            checkForWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[4] = returnSymbol(currentturn);
            button5.Text = gameBoard[4];
            checkForWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[5] = returnSymbol(currentturn);
            button6.Text = gameBoard[5];
            checkForWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[6] = returnSymbol(currentturn);
            button7.Text = gameBoard[6];
            checkForWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[7] = returnSymbol(currentturn);
            button8.Text = gameBoard[7];
            checkForWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[8] = returnSymbol(currentturn);
            button9.Text = gameBoard[8];
            checkForWinner();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
