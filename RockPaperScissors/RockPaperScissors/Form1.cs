using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            CalcWinner(1);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            CalcWinner(2);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            CalcWinner(3);
        }

        private void CalcWinner(int userguess)
        {
            int MIN = 1;
            int MAX = 4;
            string result = null;
            Random ranNumGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumGenerator.Next(MIN, MAX);


            if (userguess == 1)
            {
                if (randomNumber == 1)
                {
                    result = "You Tied. Click any button to play again.";
                }
                else if (randomNumber == 2)
                {
                    result = "You Lose. Click any button to play again.";
                }
                else if (randomNumber == 3)
                {
                    result = "You Win. Click any button to play again.";
                }
            }
            else if (userguess == 2)
            {
                if (randomNumber == 1)
                {
                    result = "You Win. Click any button to play again.";
                }
                else if (randomNumber == 2)
                {
                    result = "You Tied. Click any button to play again.";
                }
                else if (randomNumber == 3)
                {
                    result = "You Lose. Click any button to play again.";
                }
            }
            else if (userguess == 3)
            {
                if (randomNumber == 1)
                {
                    result = "You Lose. Click any button to play again.";
                }
                else if (randomNumber == 2)
                {
                    result = "You Win. Click any button to play again.";
                }
                else if (randomNumber == 3)
                {
                    result = "You Tied. Click any button to play again.";
                }
            }
            lblResult.Text = result;
        }
    }
}
