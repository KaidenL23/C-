using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CollectionsLab_Project
{
    public partial class frmCollections : Form
    {
        // Class-level constants
        private const int MAX_ELEMENTS = 17;
        private const int MIN_VALUE = -1217;
        private const int MAX_VALUE = 1217;

        // Class-level collection
        private List<int> numbers = new List<int>();
        private object lblStats;

        public frmCollections()
        {
            InitializeComponent();
            InitializeUI();
       
}

        private void InitializeUI()
        {
            throw new NotImplementedException();
        }
        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            // Validate and add number to collection
            if (ValidateInput())
            {
                AddNumberToCollection();
            }
        }
        private bool ValidateInput()
        {
            lblStats.Text = ""; // Clear previous messages

            if (string.IsNullOrEmpty(txtNumberEntry.Text))
            {
                lblStats.Text = "Error: Please enter a number.";
                return false;
            }

            if (!int.TryParse(txtNumberEntry.Text, out int number))
            {
                lblStats.Text = "Error: Invalid number format.";
                return false;
            }

            if (number < MIN_VALUE || number > MAX_VALUE)
            {
                lblStats.Text = "Error: Number out of range.";
                return false;
            }

            if (numbers.Count >= MAX_ELEMENTS)
            {
                lblStats.Text = "Error: Collection is full.";
                return false;
            }

            return true;
        }
        private void AddNumberToCollection()
        {
            int number = int.Parse(txtNumberEntry.Text);
            numbers.Add(number);
            txtNumberEntry.Clear();

            // Clear display areas after adding a new number
            rtbCollectionDisplay.Clear();
            lblStats.Text = "";
        }

        private void btnShowStats_Click(object sender, EventArgs e)
        {
            // Show collection statistics
            DisplayCollection();
            CalculateAndDisplayStats();
            ResetCollection(); // Clear the collection after displaying stats
        }

        private void DisplayCollection()
        {
            rtbCollectionDisplay.Clear();
            foreach (int number in numbers)
            {
                rtbCollectionDisplay.AppendText(number + "\n");
            }
        }

        private void CalculateAndDisplayStats()
        {
            if (numbers.Count == 0)
            {
                lblStats.Text = "Collection is empty.";
                return;
            }

            int sum = 0;
            int high = numbers[0];
            int low = numbers[0];

            foreach (int number in numbers)
            {
                sum += number;
                if (number > high)
                {
                    high = number;
                }
                if (number < low)
                {
                    low = number;
                }
            }
            double average = (double)sum / numbers.Count;

            lblStats.Text = "Statistics:\n";
            lblStats.Text += $"Average: {average:F4}\n";
            lblStats.Text += $"Highest: {high}\n";
            lblStats.Text += $"Lowest: {low}\n";
            lblStats.Text += $"Count: {numbers.Count}\n";
        }

        private void ResetCollection()
        {
            numbers.Clear();
            rtbCollectionDisplay.Clear();
            lblStats.Text = "Collection has been cleared.";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetCollection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCollections_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnExit.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnAddNumber.PerformClick();
            }
        }
    }
}