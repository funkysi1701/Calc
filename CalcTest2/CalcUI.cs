using System;
using System.Windows.Forms;

namespace CalcTest2
{
    public partial class CalcUI : Form
    {
        public CalcUI()
        {
            InitializeComponent();
            Calc.CreateResult();
            Result.Text = Calc.ClearResult();
        }
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new CalcUI());
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = "1"; }
            else Result.Text += 1;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = "2"; }
            else Result.Text += 2;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = "3"; }
            else Result.Text += 3;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = "4"; }
            else Result.Text += 4;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = "5"; }
            else Result.Text += 5;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = "6"; }
            else Result.Text += 6;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = "7"; }
            else Result.Text += 7;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = "8"; }
            else Result.Text += 8;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = "9"; }
            else Result.Text += 9;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = "0"; }
            else Result.Text += 0;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Calc.Result.Add(Result.Text);
            Result.Text = Calc.ClearResult();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            Calc.SetOperation("+");
            Calc.Result.Add(Result.Text);
            Result.Text = Calc.Screen;
        }

        private void EqualsBtn_Click(object sender, EventArgs e)
        {
            Calc.Result.Add(Result.Text);
            Calc.Evaluate(Convert.ToDouble(Calc.Result[Calc.Result.Count - 1]), Convert.ToDouble(Calc.Result[Calc.Result.Count - 2]));
            Result.Text = Calc.ReturnResult();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Calc.SetOperation("-");
            Calc.Result.Add(Result.Text);
            Result.Text = Calc.Screen;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            Calc.SetOperation("*");
            Calc.Result.Add(Result.Text);
            Result.Text = Calc.Screen;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Calc.SetOperation("/");
            Calc.Result.Add(Result.Text);
            Result.Text = Calc.Screen;
        }
    }
}
