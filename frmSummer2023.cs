using System;
using System.Drawing;
using System.Windows.Forms;

public class FrmSummer2023 : Form
{
    public FrmSummer2023()
    {
        // Set form properties
        this.Text = "Summer 2023 - Kaiden Ketcher";
        this.BackColor = Color.LightCoral;
        this.Size = new Size(800, 600);
        this.StartPosition = FormStartPosition.CenterScreen;

        // Create buttons
        Button btnWipeClear = new Button();
        Button btnSave = new Button();
        Button btnCancel = new Button();
        Button btnExit = new Button();

        // Set properties for Wipe Clear Button
        btnWipeClear.Text = "&Wipe Clear";
        btnWipeClear.BackColor = Color.White;
        btnWipeClear.ForeColor = Color.Black;
        btnWipeClear.Location = new Point(0, this.ClientSize.Height - 50);
        btnWipeClear.Size = new Size(100, 40);

        // Set properties for Save Button
        btnSave.Text = "&Save";
        btnSave.BackColor = Color.LightPink;
        btnSave.ForeColor = Color.Black;
        btnSave.Location = new Point(110, this.ClientSize.Height - 50);
        btnSave.Size = new Size(100, 40);

        // Set properties for Cancel Button
        btnCancel.Text = "Ca&ncel";
        btnCancel.BackColor = Color.Black;
        btnCancel.ForeColor = Color.Yellow;
        btnCancel.Location = new Point(220, this.ClientSize.Height - 50);
        btnCancel.Size = new Size(100, 40);

        // Set properties for Exit Button
        btnExit.Text = "&Exit";
        btnExit.BackColor = Color.Yellow;
        btnExit.ForeColor = Color.Black;
        btnExit.Location = new Point(330, this.ClientSize.Height - 50);
        btnExit.Size = new Size(100, 40);

        // Add buttons to form
        this.Controls.Add(btnWipeClear);
        this.Controls.Add(btnSave);
        this.Controls.Add(btnCancel);
        this.Controls.Add(btnExit);

        // Create label and textbox
        Label lblEnterText = new Label();
        TextBox txtInputText = new TextBox();

        // Set properties for Label
        lblEnterText.Text = "Enter Text here";
        lblEnterText.Font = new Font("Times New Roman", 16, FontStyle.Bold);
        lblEnterText.TextAlign = ContentAlignment.MiddleRight;
        lblEnterText.Location = new Point(0, 0);
        lblEnterText.Size = new Size(200, 40);

        // Set properties for TextBox
        txtInputText.Font = new Font("Times New Roman", 16);
        txtInputText.Location = new Point(210, 0);
        txtInputText.Size = new Size(400, 40);

        // Add label and textbox to form
        this.Controls.Add(lblEnterText);
        this.Controls.Add(txtInputText);

        // Assign event handlers
        btnExit.Click += (sender, e) => this.Close();
    }

    // Handle key press events for hotkeys
    protected override void OnKeyDown(KeyEventArgs e)
    {
        base.OnKeyDown(e);

        if (e.KeyCode == Keys.W)
            MessageBox.Show("Wipe Clear pressed");
        else if (e.KeyCode == Keys.S)
            MessageBox.Show("Save pressed");
        else if (e.KeyCode == Keys.C)
            MessageBox.Show("Cancel pressed");
        else if (e.KeyCode == Keys.X)
            MessageBox.Show("Exit pressed");
    }

    
}
