using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahrenheitToCelsius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double input8;
        double input12;
        double input5;
        double output8;
        double output12;
        double output5;

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            input8 = Convert.ToDouble(txtInput8.Text);
            input12 = Convert.ToDouble(txtInput12.Text);
            input5 = Convert.ToDouble(txtInput5.Text);

            output8 = (input8 - 32) * 5/9;
            output12 = (input12 - 32) * 5/9;
            output5 = (input5 - 32) * 5/9;

            if (input8 <= 32)
                lblOutput8.Text = "It is freezing. " + Math.Round(output8, 2) + "C°";
            else if (input8 >= 100)
                lblOutput8.Text = "It is Hot out. " + Math.Round(output8, 2) + "C°";
            else
                lblOutput8.Text = "It is " + Math.Round(output8, 2) + "C°";

            if (input12 < 32)
                lblOutput12.Text = "It is freezing." + Math.Round(output12, 2) + "C°";
            else if (input12 > 100)
                lblOutput12.Text = "It is Hot out." + Math.Round(output12, 2) + "C°";
            else
                lblOutput12.Text = "It is " + Math.Round(output12, 2) + "C° outside.";

            if (input5 < 32)
                lblOutput5.Text = "It is freezing." + Math.Round(output5, 2) + "C°";
            else if (input5 > 100)
                lblOutput5.Text = "It is Hot out." + Math.Round(output5, 2) + "C°";
            else
                lblOutput5.Text = "It is " + Math.Round(output5, 2) + "C°";

            pictFormulaCelsius.Visible = false;
            pictFormulaFahrenheit.Visible = true;
            lblInput.Text = "Fahrenheit";
            lblOutput.Text = "Celsius";

        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            input8 = Convert.ToDouble(txtInput8.Text);
            input12 = Convert.ToDouble(txtInput12.Text);
            input5 = Convert.ToDouble(txtInput5.Text);

            output8 = (input8 * 1.8) + 32;
            output12 = (input12 * 1.8) + 32;
            output5 = (input5 * 1.8) + 32;

            if (output8 <= 32)
                lblOutput8.Text = "It is freezing. " + Math.Round(output8, 2) + "F°";
            else if (output8 >= 100)
                lblOutput8.Text = "It is Hot out. " + Math.Round(output8, 2) + "F°";
            else
                lblOutput8.Text = "It is " + Math.Round(output8, 2) + "F°";

            if (output12 < 32)
                lblOutput12.Text = "It is freezing." + Math.Round(output12, 2) + "F°";
            else if (output12 > 100)
                lblOutput12.Text = "It is Hot out." + Math.Round(output12, 2) + "F°";
            else
                lblOutput12.Text = "It is " + Math.Round(output12, 2) + "F° outside.";

            if (output5 < 32)
                lblOutput5.Text = "It is freezing." + Math.Round(output5, 2) + "F°";
            else if (output5 > 100)
                lblOutput5.Text = "It is Hot out." + Math.Round(output5, 2) + "F°";
            else
                lblOutput5.Text = "It is " + Math.Round(output5, 2) + "F°";

            pictFormulaCelsius.Visible = true;
            pictFormulaFahrenheit.Visible = false;
            lblInput.Text = "Celsius";
            lblOutput.Text = "Fahrenheit";
        }
    }
}
