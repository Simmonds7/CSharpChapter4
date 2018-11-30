using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfStatementCheckboxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Text = "Checkbox 1 is checked.";
            }
            else if (checkBox2.Checked)
            {
                label1.Text = "Checkbox 2 is checked.";
            }
            else if (checkBox3.Checked)
            {
                label1.Text = "Checkbox 3 is checked.";
            }
            else if (checkBox2.Checked && checkBox3.Checked)
            {
                label1.Text = "Checkbox 2 and 3 are checked.";
            }
        }
    }
}
