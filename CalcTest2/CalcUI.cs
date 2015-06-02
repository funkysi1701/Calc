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
            numberpad(1);
        }

        private void Two_Click(object sender, EventArgs e)
        {
            numberpad(2);
        }

        private void Three_Click(object sender, EventArgs e)
        {
            numberpad(3);
        }

        private void Four_Click(object sender, EventArgs e)
        {
            numberpad(4);
        }

        private void Five_Click(object sender, EventArgs e)
        {
            numberpad(5);
        }

        private void Six_Click(object sender, EventArgs e)
        {
            numberpad(6);
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            numberpad(7);
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            numberpad(8);
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            numberpad(9);
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            numberpad(0);
        }

        public void numberpad(int number)
        {
            if (Result.Text == "0") { Result.Text = number.ToString(); }
            else Result.Text += number;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Point.Enabled = true;
            Calc.Result.Add(Result.Text);
            Result.Text = Calc.ClearResult();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            Point.Enabled = true;
            Calc.SetOperation("+");
            Calc.Result.Add(Result.Text);
            Result.Text = Calc.ClearResult();
        }

        private void EqualsBtn_Click(object sender, EventArgs e)
        {
            Point.Enabled = true;
            Calc.Result.Add(Result.Text);
            Calc.Evaluate(Convert.ToDouble(Calc.Result[Calc.Result.Count - 1]), Convert.ToDouble(Calc.Result[Calc.Result.Count - 2]));
            Result.Text = Calc.ReturnResult();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Point.Enabled = true;
            Calc.SetOperation("-");
            Calc.Result.Add(Result.Text);
            Result.Text = Calc.ClearResult();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            Point.Enabled = true;
            Calc.SetOperation("*");
            Calc.Result.Add(Result.Text);
            Result.Text = Calc.ClearResult();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Point.Enabled = true;
            Calc.SetOperation("/");
            Calc.Result.Add(Result.Text);
            Result.Text = Calc.ClearResult();
        }

        private void SignChange_Click(object sender, EventArgs e)
        {
            Result.Text = Calc.ChangeSign(Convert.ToDouble(Result.Text)).ToString();
        }

        private void Point_Click(object sender, EventArgs e)
        {
            Result.Text += ".";
            Point.Enabled = false;
        }
    }
}
