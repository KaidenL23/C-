using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module6MethodsProjectDL
{
    public partial class frmMethodActing : Form
    {
        // Public Contsants to use
        const byte ADD = 0;
        const byte SUBTRACT = 1;
        const byte MULTIPLY = 2;
        const byte DIVIDE = 3;
        const byte MODULUS = 4;

        public frmMethodActing()
        {
            InitializeComponent();
        }

        //Put Your method here

        private void button5_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeftOperand.Text;
            szRight = txtRightOperand.Text;

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = dLeft % dRight;

            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " % " + szRight + " = " + szAnswer;

            lblResult.Text = "";
            lblResult.Text = szEquation;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeftOperand.Text;
            szRight = txtRightOperand.Text;

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = dLeft / dRight;

            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " / " + szRight + " = " + szAnswer;

            lblResult.Text = "";
            lblResult.Text = szEquation;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeftOperand.Text;
            szRight = txtRightOperand.Text;

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = dLeft * dRight;

            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " * " + szRight + " = " + szAnswer;

            lblResult.Text = "";
            lblResult.Text = szEquation;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeftOperand.Text;
            szRight = txtRightOperand.Text;

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = dLeft - dRight;

            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " - " + szRight + " = " + szAnswer;

            lblResult.Text = "";
            lblResult.Text = szEquation;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeftOperand.Text;
            szRight = txtRightOperand.Text;

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = dLeft + dRight;

            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " + " + szRight + " = " + szAnswer;

            lblResult.Text = "";
            lblResult.Text = szEquation;

        }

        private void txtLeftOperand_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
