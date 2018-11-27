using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string message;
            const int MAX = 140;

            message = txtTwitterMsg.Text;

            if (message.Length >= MAX)
            {
                lblCounter.Text = message.Length + " Over Limit";
                lblCounter.ForeColor = Color.FromArgb(255, 0, 0);
                lblPostedMsg.Text = "Not Posted.";
            }
                
            else
            {
                lblCounter.Text = message.Length + " Under Limit";
                lblCounter.ForeColor = System.Drawing.Color.Black;
                lblPostedMsg.Text = "Posted.";
            }
        }
    }
}
