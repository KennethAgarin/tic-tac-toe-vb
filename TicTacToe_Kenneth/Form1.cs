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

        private void button1_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[0] = returnSymbol(currentturn);
            button1.Text = gameBoard[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[1] = returnSymbol(currentturn);
            button2.Text = gameBoard[1];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[2] = returnSymbol(currentturn);
            button3.Text = gameBoard[2];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[3] = returnSymbol(currentturn);
            button4.Text = gameBoard[3];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[4] = returnSymbol(currentturn);
            button5.Text = gameBoard[4];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[5] = returnSymbol(currentturn);
            button6.Text = gameBoard[5];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[6] = returnSymbol(currentturn);
            button7.Text = gameBoard[6];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[7] = returnSymbol(currentturn);
            button8.Text = gameBoard[7];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentturn++;
            gameBoard[8] = returnSymbol(currentturn);
            button9.Text = gameBoard[8];
        }
    }
}
