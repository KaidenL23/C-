using System;
using System.Windows.Forms;

namespace Module6MethodsProjectDL
{
    public partial class Form1 : Form
    {
        // Public Constants to use
        const byte ADD = 0;
        const byte SUBTRACT = 1;
        const byte MULTIPLY = 2;
        const byte DIVIDE = 3;
        const byte MODULUS = 4;

        public Form1()
        {
            InitializeComponent();
        }

        // Method to perform calculations and display the result
        private void CalculateAndDisplay(byte operation)
        {
            label3.Text = ""; // Clear previous result

            if (!decimal.TryParse(textBox2.Text, out decimal dLeft) ||
                !decimal.TryParse(textBox1.Text, out decimal dRight))
            {
                label3.Text = "Error: Please enter valid numbers in both textboxes.";
                return;
            }

            try
            {
                decimal dAnswer = 0.0m;
                string szEquation = "";

                switch (operation)
                {
                    case ADD:
                        dAnswer = dLeft + dRight;
                        szEquation = $"{dLeft} + {dRight} = {dAnswer}";
                        break;
                    case SUBTRACT:
                        dAnswer = dLeft - dRight;
                        szEquation = $"{dLeft} - {dRight} = {dAnswer}";
                        break;
                    case MULTIPLY:
                        dAnswer = dLeft * dRight;
                        szEquation = $"{dLeft} * {dRight} = {dAnswer}";
                        break;
                    case DIVIDE:
                        if (dRight == 0)
                        {
                            label3.Text = "Error: Cannot divide by zero.";
                            return;
                        }
                        dAnswer = dLeft / dRight;
                        szEquation = $"{dLeft} / {dRight} = {dAnswer}";
                        break;
                    case MODULUS:
                        if (dLeft < 0 || dRight < 0)
                        {
                            label3.Text = "Error: Cannot perform modulus with negative numbers.";
                            return;
                        }
                        dAnswer = dLeft % dRight;
                        szEquation = $"{dLeft} % {dRight} = {dAnswer}";
                        break;
                }

                label3.Text = szEquation;
            }
            catch (Exception ex)
            {
                label3.Text = "An unexpected error occurred: " + ex.Message;
            }
        }

        // Button click event handlers
        private void button1_Click(object sender, EventArgs e)
        {
            CalculateAndDisplay(ADD);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculateAndDisplay(SUBTRACT);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculateAndDisplay(MULTIPLY);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalculateAndDisplay(DIVIDE);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CalculateAndDisplay(MODULUS);
        }
    }
}
