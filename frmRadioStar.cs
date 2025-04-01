using System;
using System.Drawing;
using System.Windows.Forms;

namespace RadioStarApp_Project
{
    public partial class frmRadioStar : Form
    {
        public frmRadioStar() => InitializeComponent();

    }

    private void frmRadioStar_Load(object sender, EventArgs e)
    {
        this.Text = "Radio Buttons in Action";
        this.BackColor = Color.LightSteelBlue;
        this.StartPosition = FormStartPosition.CenterScreen;

        txtLeftOperand.BackColor = Color.LightYellow;
        txtRightOperand.BackColor = Color.LightYellow;

        rdoAddition.Checked = true;
        chkVerbose.Checked = true;
        txtLeftOperand.Focus();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(txtLeftOperand.Text) && string.IsNullOrEmpty(txtRightOperand.Text))
            {
                lblMessage.Text = "Both operands are empty.";
                return;
            }

            if (string.IsNullOrEmpty(txtLeftOperand.Text))
            {
                lblMessage.Text = "Left operand is empty.";
                return;
            }

            if (string.IsNullOrEmpty(txtRightOperand.Text))
            {
                lblMessage.Text = "Right operand is empty.";
                return;
            }

            if (!int.TryParse(txtLeftOperand.Text, out int leftOperand))
            {
                lblMessage.Text = "Left operand is not a valid integer.";
                return;
            }

            if (!int.TryParse(txtRightOperand.Text, out int rightOperand))
            {
                lblMessage.Text = "Right operand is not a valid integer.";
                return;
            }

            int result = 0;
            string operationSymbol = "";

            if (rdoAddition.Checked)
            {
                result = leftOperand + rightOperand;
                operationSymbol = "+";
            }
            else if (rdoSubtraction.Checked)
            {
                result = leftOperand - rightOperand;
                operationSymbol = "-";
            }
            else if (rdoMultiplication.Checked)
            {
                result = leftOperand * rightOperand;
                operationSymbol = "*";
            }
            else if (rdoDivision.Checked)
            {
                if (rightOperand == 0)
                {
                    lblMessage.Text = "Cannot divide by zero.";
                    return;
                }
                result = leftOperand / rightOperand;
                operationSymbol = "/";
            }
            else if (rdoModulus.Checked)
            {
                if (rightOperand == 0)
                {
                    lblMessage.Text = "Cannot calculate modulus with zero.";
                    return;
                }
                if (leftOperand < 0 || rightOperand < 0)
                {
                    object lblMessage = null;
                    lblMessage.Text = "Modulus operation is not allowed for negative numbers.";
                    return;
                }
                result = leftOperand % rightOperand;
                operationSymbol = "%";
            }

            if (chkVerbose.Checked)
            {
                lblMessage.Text = $"{leftOperand} {operationSymbol} {rightOperand} = {result}";
            }
            else
            {
                lblMessage.Text = $"The Answer is: {result}";
            }
        }
        catch (Exception ex)
        {
            lblMessage.Text = $"An unexpected error occurred: {ex.Message}";
        }
    }

    private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmRadioStar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        

        }

        private void LblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}