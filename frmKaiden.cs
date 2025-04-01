using System;
using System.Drawing;
using System.Windows.Forms;

public class frmKetcher : Form
{
    private Label lblTheDominator;
    private Button btnClear, btnExit;
    private Button[] colorButtons;
    private Button[] digitButtons;

    public frmKetcher()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "frmKetcher";
        this.Size = new Size(400, 400);

        lblTheDominator = new Label()
        {
            Name = "lblTheDominator",
            Size = new Size(100, 50),
            Location = new Point(150, 20),
            BackColor = Color.White,
            TextAlign = ContentAlignment.MiddleCenter
        };
        this.Controls.Add(lblTheDominator);

        string[] colors = { "Red", "Yellow", "Brown", "Blue", "Orange", "Pink", "Green", "Purple", "Cyan" };
        Color[] colorValues = { Color.Red, Color.Yellow, Color.Brown, Color.Blue, Color.Orange, Color.Pink, Color.Green, Color.Purple, Color.Cyan };

        colorButtons = new Button[colors.Length];
        for (int i = 0; i < colors.Length; i++)
        {
            colorButtons[i] = new Button()
            {
                Text = colors[i],
                Location = new Point(10 + (i % 3) * 80, 80 + (i / 3) * 40),
                BackColor = colorValues[i]
            };
            colorButtons[i].Click += (sender, e) => lblTheDominator.BackColor = colorValues[i];
            this.Controls.Add(colorButtons[i]);
        }

        digitButtons = new Button[9];
        for (int i = 0; i < 9; i++)
        {
            digitButtons[i] = new Button()
            {
                Text = (i + 1).ToString(),
                Location = new Point(10 + (i % 3) * 60, 200 + (i / 3) * 40),
            };
            digitButtons[i].Click += (sender, e) => lblTheDominator.Text = ((Button)sender).Text;
            this.Controls.Add(digitButtons[i]);
        }

        btnClear = new Button()
        {
            Text = "Clear",
            Location = new Point(10, 320)
        };
        btnClear.Click += (sender, e) => { lblTheDominator.Text = ""; lblTheDominator.BackColor = Color.White; };
        this.Controls.Add(btnClear);

        btnExit = new Button()
        {
            Text = "Exit",
            Location = new Point(100, 320)
        };
        btnExit.Click += (sender, e) => this.Close();
        this.Controls.Add(btnExit);
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new frmKetcher());
    }
}
