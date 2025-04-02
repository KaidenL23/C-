using System;
using System.Drawing;
using System.Windows.Forms;

namespace Module3Exercise2Project
{
    public partial class Form1 : Form
    {
        private Label lblMessage;
        private Button btnRed;
        private Button btnBlue;
        private Button btnL;
        private Button btnR;
        private Button btnExit;

        public Form1()
        {
            InitializeComponent();  // This is the auto-generated method call from the Designer.cs file
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            this.KeyPreview = true;

            lblMessage = new Label
            {
                Text = "Message",
                Font = new Font("Times New Roman", 16, FontStyle.Bold),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.LightGray,
                Width = 250,   // Increased width for visibility
                Height = 50,   // Increased height for visibility
                Location = new Point(100, 50)
            };

            // Create Red Button
            btnRed = new Button
            {
                Text = "&Red",
                BackColor = Color.Red,
                Width = 75,
                Height = 50,
                Location = new Point(lblMessage.Left, lblMessage.Top - 60)
            };
            btnRed.Click += new EventHandler(btnRed_Click);

            // Create Blue Button
            btnBlue = new Button
            {
                Text = "&Blue",
                BackColor = Color.Blue,
                Width = 75,
                Height = 50,
                Location = new Point(lblMessage.Right - 75, lblMessage.Top - 60)
            };
            btnBlue.Click += new EventHandler(btnBlue_Click);

            // Create Left Button
            btnL = new Button
            {
                Text = "&L",
                Width = 75,
                Height = 50,
                Location = new Point(lblMessage.Left, lblMessage.Bottom + 10)
            };
            btnL.Click += new EventHandler(btnL_Click);

            // Create Right Button
            btnR = new Button
            {
                Text = "&R",
                Width = 75,
                Height = 50,
                Location = new Point(lblMessage.Right - 75, lblMessage.Bottom + 10)
            };
            btnR.Click += new EventHandler(btnR_Click);

            // Create Exit Button
            btnExit = new Button
            {
                Text = "Exit",
                Width = lblMessage.Width,
                Height = 50,
                Location = new Point(lblMessage.Left, lblMessage.Bottom + 70)
            };
            btnExit.Click += new EventHandler(btnExit_Click);

            // Add Controls
            this.Controls.Add(lblMessage);
            this.Controls.Add(btnRed);
            this.Controls.Add(btnBlue);
            this.Controls.Add(btnL);
            this.Controls.Add(btnR);
            this.Controls.Add(btnExit);

            // Set TabIndex for button tab order
            btnRed.TabIndex = 0;
            btnBlue.TabIndex = 1;
            btnL.TabIndex = 2;
            btnR.TabIndex = 3;
            btnExit.TabIndex = 4;

            // Escape key to close the form
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            };
        }

        private void btnR_Click(object sender, EventArgs e) { lblMessage.Text = btnR.Text; }
        private void btnRed_Click(object sender, EventArgs e) { lblMessage.BackColor = btnRed.BackColor; }
        private void btnBlue_Click(object sender, EventArgs e) { lblMessage.BackColor = btnBlue.BackColor; }
        private void btnL_Click(object sender, EventArgs e) { lblMessage.Text = btnL.Text; }
        private void btnExit_Click(object sender, EventArgs e) { this.Close(); }
    }
}



