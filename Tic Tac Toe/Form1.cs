using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] board = new string[10];
        int myTurn = 0;
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
            
        public void Winner()
        {
            for(int i = 0; i < 8; i++)
            {
                String combination = "";

                switch(i)
                {
                    case 0:
                        combination = board[1] + board[5] + board[9];
                        break;
                    case 1:
                        combination = board[3] + board[5] + board[7];
                        break;
                    case 2:
                        combination = board[1] + board[2] + board[3];
                        break;
                    case 3:
                        combination = board[4] + board[5] + board[6];
                        break;
                    case 4:
                        combination = board[7] + board[8] + board[9];
                        break;
                    case 5:
                        combination = board[1] + board[4] + board[7];
                        break;
                    case 6:
                        combination = board[2] + board[5] + board[8];
                        break;
                    case 7:
                        combination = board[3] + board[6] + board[9];
                        break;
                }
                
                if(combination.Equals("XXX"))
                {
                    restart();
                    MessageBox.Show("X wins! ", "We have a Winner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(combination.Equals("OOO"))
                {
                    restart();
                    MessageBox.Show("O wins! ", "We have a Winner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                draw();
            }
            
        }

        
            
        
        public void restart()
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
            board = new string[10];
            myTurn = 0;

        }

        public void draw()
        {
            int count = 0;
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] != null) { count++; }

                if (count == 9)
                {
                    restart();
                    MessageBox.Show("It is a DRAW!", "Draw!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myTurn++;
            board[1] = returnSymbol(myTurn);
            button1.Text = board[1];
            Winner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myTurn++;
            board[2] = returnSymbol(myTurn);
            button2.Text = board[2];
            Winner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myTurn++;
            board[3] = returnSymbol(myTurn);
            button3.Text = board[3];
            Winner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myTurn++;
            board[4] = returnSymbol(myTurn);
            button4.Text = board[4];
            Winner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            myTurn++;
            board[5] = returnSymbol(myTurn);
            button5.Text = board[5];
            Winner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            myTurn++;
            board[6] = returnSymbol(myTurn);
            button6.Text = board[6];
            Winner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            myTurn++;
            board[7] = returnSymbol(myTurn);
            button7.Text = board[7];
            Winner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            myTurn++;
            board[8] = returnSymbol(myTurn);
            button8.Text = board[8];
            Winner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            myTurn++;
            board[9] = returnSymbol(myTurn);
            button9.Text = board[9];
            Winner();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
