using System;
using System.Drawing;
using System.Windows.Forms;

namespace Week_4_to_7_2_Lab_Project
{
    public partial class Form1 : Form
    {
        private const bool V = false;

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
        }

        private Button GetBtnProcess()
        {
            return btnProcess;
        }

        private void InitializeUI(Button btnProcess)
        {
            btnProcess.Enabled = V;
            lblResult.BackColor = Color.LightCyan; // Example color
            lblResult.Font = new Font(lblResult.Font, FontStyle.Bold);
        }
        private void txtConvertFrom_TextChanged(object sender, EventArgs e)
        {
            // Enable/disable buttons based on input
            EnableButtons();
        }
        private void txtBase_TextChanged(object sender, EventArgs e)
        {
            // Enable/disable buttons based on input
            EnableButtons();
        }
        private void EnableButtons()
        {
            // Enable specific base buttons if txtConvertFrom has content
            btnBinary.Enabled = !string.IsNullOrEmpty(txtConvertFrom.Text);
            btnHex.Enabled = !string.IsNullOrEmpty(txtConvertFrom.Text);
            btnOctal.Enabled = !string.IsNullOrEmpty(txtConvertFrom.Text);
            btnBase6.Enabled = !string.IsNullOrEmpty(txtConvertFrom.Text);
            btnBase9.Enabled = !string.IsNullOrEmpty(txtConvertFrom.Text);

            // Enable Process button if both textboxes have content
            btnProcess.Enabled = !string.IsNullOrEmpty(txtConvertFrom.Text) &&
                                 !string.IsNullOrEmpty(txtBase.Text);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all textboxes and the result label
            txtConvertFrom.Clear();
            txtBase.Clear();
            lblResult.Text = "";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle the Escape key to exit
            if (e.KeyCode == Keys.Escape)
            {
                btnExit_Click(sender, e);
            }
        }
        private void ConvertAndDisplay(int number, int baseToConvertTo)
        {
            try
            {
                // Validate input
                if (!ValidateInput(number, baseToConvertTo))
                {
                    return; // Error message already displayed in lblResult
                }
                // Convert the number to the specified base
                string convertedNumber = ConvertToBase(number, baseToConvertTo);

                // Display the result
                lblResult.Text = $"{GetBasePrefix(baseToConvertTo)}{convertedNumber}";
            }
            catch (Exception ex)
            {
                lblResult.Text = "Error: " + ex.Message;
            }
        }
        private bool ValidateInput(int number, int baseToConvertTo)
        {
            if (number < 0)
            {
                lblResult.Text = "Error: Number cannot be negative.";
                return false;
            }
            if (baseToConvertTo < 2 || baseToConvertTo > 16)
            {
                lblResult.Text = "Error: Base must be between 2 and 16.";
                return false;
            }
            return true;
        }
        private string ConvertToBase(int number, int baseToConvertTo)
        {
            // Implement the conversion algorithm here
            // (Refer to the supplemental information for the algorithm)

            string result = "";
            string digits = "0123456789ABCDEF";

            if (number == 0)
            {
                return "0";
            }
            while (number > 0)
            {
                int remainder = number % baseToConvertTo;
                result = digits[remainder] + result;
                number /= baseToConvertTo;
            }

            return result;
        }
        private string GetBasePrefix(int baseToConvertTo)
        {
            // Return the appropriate prefix for the base
            return baseToConvertTo == 16 ? "0x" : $"{baseToConvertTo}x";
        }
        // Event handlers for specific base buttons
        private void btnBinary_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtConvertFrom.Text, out int number))
            {
                ConvertAndDisplay(number, 2);
            }
            else
            {
                lblResult.Text = "Error: Invalid input.";
            }
        }
        private void btnHex_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtConvertFrom.Text, out int number))
            {
                ConvertAndDisplay(number, 16);
            }
            else
            {
                lblResult.Text = "Error: Invalid input.";
            }
        }

        private void btnOctal_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtConvertFrom.Text, out int number))
            {
                ConvertAndDisplay(number, 8);
            }
            else
            {
                lblResult.Text = "Error: Invalid input.";
            }
        }

        private void btnBase6_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtConvertFrom.Text, out int number))
            {
                ConvertAndDisplay(number, 6);
            }
            else
            {
                lblResult.Text = "Error: Invalid input.";
            }
        }

        private void btnBase9_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtConvertFrom.Text, out int number))
            {
                ConvertAndDisplay(number, 9);
            }
            else
            {
                lblResult.Text = "Error: Invalid input.";
            }
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtConvertFrom.Text, out int number) &&
                int.TryParse(txtBase.Text, out int baseToConvertTo))
            {
                ConvertAndDisplay(number, baseToConvertTo);
            }

            else
            {
                lblResult.Text = "Error: Invalid input.";
            }
        }
    }
}