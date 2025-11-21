using System.Data;

using System.Drawing; // Required for Color properties
using System.Data;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }
        private void Number_Click(object sender, EventArgs e)
        {

            Button clickedButton = (Button)sender;

            string number = clickedButton.Text;

            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = number;
            }
            else
            {
                Display.Text = Display.Text + number;
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "+";
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "-";
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "*";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "/";
        }

        private void Equ_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();

                var result = table.Compute(Display.Text, "");

                Display.Text = result.ToString();
            }
            catch (System.Data.SyntaxErrorException)
            { 
                MessageBox.Show("Felaktig matematik! Du försökte räkna ut: " + Display.Text);
                Display.Text = "0";
            }
        }
    }


}
