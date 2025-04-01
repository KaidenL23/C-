using System;
using System.Windows.Forms;

namespace Module4Project
{
    /* 
     * Author: Kaiden Ketcher
     * Class: frmOfDataTypes
     * Due Date: [2-5-2025]
     */

    public partial class frmOfDataTypes : Form
    {
        public frmOfDataTypes()
        {
            InitializeComponent();  // Initializes the components of the form
        }

        private void frmOfDataTypes_Load(object sender, EventArgs e)
        {
            // Set initial form properties
            this.StartPosition = FormStartPosition.CenterScreen;  // Center the form on the screen
            this.Text = "Week 4 - Data Types";  // Set the form's title

            // Add Buttons to the Form and set properties
            AddButtons();  // Call the method to add buttons
        }

        private void AddButtons()
        {
            // Integer buttons: byte, short, int, long
            CreateButton("btnByte", "Byte", 10, 10, clickEvent: btnByte_Click, hotkey: "B");  // Create Byte button
            CreateButton("btnShort", "Short", 10, 60, clickEvent: btnShort_Click, hotkey: "S");  // Create Short button
            CreateButton("btnInt", "Int", 10, 110, clickEvent: btnInt_Click, hotkey: "I");  // Create Int button
            CreateButton("btnLong", "Long", 10, 160, clickEvent: btnLong_Click, "L");  // Create Long button

            // Decimal buttons: float, double, decimal
            CreateButton("btnFloat", "Float", 120, 10, clickEvent: btnFloat_Click, hotkey: "F");  // Create Float button
            CreateButton("btnDouble", "Double", 120, 60, clickEvent: btnDouble_Click, hotkey: "D");  // Create Double button
            CreateButton("btnDecimal", "Decimal", 120, 110, clickEvent: btnDecimal_Click, hotkey: "M");  // Create Decimal button

            // Math ops buttons: Pow, Round, Sqrt
            CreateButton("btnPow", "Pow", 230, 10, clickEvent: btnPow_Click, hotkey: "P");  // Create Power button
            CreateButton("btnRound", "Round", 230, 60, clickEvent: btnRound_Click, hotkey: "R");  // Create Round button
            CreateButton("btnSqrt", "Sqrt", 230, 110, clickEvent: btnSqrt_Click, hotkey: "T");  // Create Square Root button

            // Clear and Exit buttons
            CreateButton("btnClear", "Clear", 340, 10, clickEvent: btnClear_Click, hotkey: "C");  // Create Clear button
            CreateButton("btnExit", "Exit", 340, 60, clickEvent: btnExit_Click, hotkey: "E");  // Create Exit button

            // Label in the center
            lblDisplay = new Label
            {
                Name = "lblDisplay",  // Name the label as lblDisplay
                Text = "Click a Button",  // Set initial text for the label
                TextAlign = ContentAlignment.MiddleCenter,  // Align text to the center
                Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold),  // Set font size and style
                BackColor = System.Drawing.Color.LightPink,  // Set background color for the label
                ForeColor = System.Drawing.Color.Black,  // Set text color for the label
                Size = new System.Drawing.Size(785, 221),  // Set the size of the label
                Location = new System.Drawing.Point(10, 250)  // Set the location of the label on the form
            };
            this.Controls.Add(lblDisplay);  // Add the label to the form
        }

        private void CreateButton(string name, string text, int x, int y, EventHandler clickEvent, string hotkey)
        {
            // Create a new button and set its properties
            Button button = new Button
            {
                Name = name,  // Set the button's name
                Text = text,  // Set the button's text
                Size = new System.Drawing.Size(100, 40),  // Set the button size
                Location = new System.Drawing.Point(x, y),  // Set the button location on the form
                BackColor = System.Drawing.Color.LightBlue,  // Set the background color for the button
                ForeColor = System.Drawing.Color.Black,  // Set text color for the button
                Font = new System.Drawing.Font("Segoe UI", 12F),  // Set the font style for the button text
                TabStop = true  // Set the button to be included in tab order
            };

            button.Click += clickEvent;  // Assign the click event to the button

            // Set Hotkey (Alt + letter)
            button.Tag = hotkey;  // Store the hotkey letter in the button's Tag property
            button.KeyDown += Button_KeyDown;  // Attach KeyDown event for hotkey handling

            this.Controls.Add(button);  // Add the button to the form
        }

        // Hotkey handling for the buttons
        private void Button_KeyDown(object sender, KeyEventArgs e)
        {
            Button button = sender as Button;
            if (button != null && e.Alt && e.KeyCode.ToString().ToUpper() == button.Tag.ToString())
            {
                button.PerformClick();  // Simulate a button click if the hotkey is pressed
            }
        }

        // Button click event handlers (these will perform calculations or actions)

        // Handle the Byte button click event
        private void btnByte_Click(object sender, EventArgs e)
        {
            byte leftOperand = 2;
            byte rightOperand = 3;
            byte result = (byte)(leftOperand + rightOperand);

            lblDisplay.Text = $"{leftOperand} + {rightOperand} = {result}";  // Display the result in the label
        }

        // Handle the Short button click event
        private void btnShort_Click(object sender, EventArgs e)
        {
            short leftOperand = 10;
            short rightOperand = 4;
            short result = (short)(leftOperand - rightOperand);

            lblDisplay.Text = $"{leftOperand} - {rightOperand} = {result}";  // Display the result in the label
        }

        // Handle the Int button click event
        private void btnInt_Click(object sender, EventArgs e)
        {
            int leftOperand = 10;
            int rightOperand = 5;
            int result = leftOperand / rightOperand;

            lblDisplay.Text = $"{leftOperand} / {rightOperand} = {result}";  // Display the result in the label
        }

        // Handle the Long button click event
        private void btnLong_Click(object sender, EventArgs e)
        {
            long leftOperand = 100;
            long rightOperand = 7;
            long result = leftOperand % rightOperand;

            lblDisplay.Text = $"{leftOperand} % {rightOperand} = {result}";  // Display the result in the label
        }

        // Handle the Float button click event
        private void btnFloat_Click(object sender, EventArgs e)
        {
            float leftOperand = 10.0f;
            float rightOperand = 3.0f;
            float result = leftOperand % rightOperand;

            lblDisplay.Text = $"{leftOperand} % {rightOperand} = {result:F7}";  // Display the result in the label (7 decimal places)
        }

        // Handle the Double button click event
        private void btnDouble_Click(object sender, EventArgs e)
        {
            double leftOperand = 10.0;
            double rightOperand = 3.0;
            double result = leftOperand / rightOperand;

            lblDisplay.Text = $"{leftOperand} / {rightOperand} = {result:F7}";  // Display the result in the label (7 decimal places)
        }

        // Handle the Decimal button click event
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            decimal leftOperand = 10.0m;
            decimal rightOperand = 5.0m;
            decimal result = leftOperand * rightOperand;

            lblDisplay.Text = $"{leftOperand} * {rightOperand} = {result}";  // Display the result in the label
        }

        // Handle the Power button click event
        private void btnPow_Click(object sender, EventArgs e)
        {
            double result = Math.Pow(2, 3);  // 2 raised to the power of 3
            lblDisplay.Text = $"2^3 = {result}";  // Display the result in the label
        }

        // Handle the Round button click event
        private void btnRound_Click(object sender, EventArgs e)
        {
            double result = Math.Round(3.14159, 2);  // Rounding Pi to 2 decimal places
            lblDisplay.Text = $"Round(3.14159, 2) = {result}";  // Display the result in the label
        }

        // Handle the Square Root button click event
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double result = Math.Sqrt(16);  // Square root of 16
            lblDisplay.Text = $"Sqrt(16) = {result}";  // Display the result in the label
        }

        // Handle the Clear button click event
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";  // Clears the label text
        }

        // Handle the Exit button click event
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  // Closes the application
        }
    }
}


