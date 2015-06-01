using System;
using System.Windows.Forms;

namespace CalcTest2
{
    public partial class CalcUI : Form
    {
        public CalcUI()
        {
            InitializeComponent();
            Calc.ClearResult();
            Result.Text = Calc.ReturnResult().ToString();
        }
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new CalcUI());
        }

        private void One_Click(object sender, EventArgs e)
        {
            Calc.Result1 = Convert.ToDouble(Calc.Result1.ToString() + "1");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Two_Click(object sender, EventArgs e)
        {
            Calc.Result1 = Convert.ToDouble(Calc.Result1.ToString() + "2");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Three_Click(object sender, EventArgs e)
        {
            Calc.Result1 = Convert.ToDouble(Calc.Result1.ToString() + "3");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Four_Click(object sender, EventArgs e)
        {
            Calc.Result1 = Convert.ToDouble(Calc.Result1.ToString() + "4");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Five_Click(object sender, EventArgs e)
        {
            Calc.Result1 = Convert.ToDouble(Calc.Result1.ToString() + "5");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Six_Click(object sender, EventArgs e)
        {
            Calc.Result1 = Convert.ToDouble(Calc.Result1.ToString() + "6");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            Calc.Result1 = Convert.ToDouble(Calc.Result1.ToString() + "7");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            Calc.Result1 = Convert.ToDouble(Calc.Result1.ToString() + "8");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            Calc.Result1 = Convert.ToDouble(Calc.Result1.ToString() + "9");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            Calc.Result1 = Convert.ToDouble(Calc.Result1.ToString() + "0");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Calc.ClearResult();
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            Calc.SetOperation("+");
            Calc.CopyResult();
            Calc.ClearResult();
        }

        private void EqualsBtn_Click(object sender, EventArgs e)
        {
            if(Calc.Operation == "+")
            {
                
                Calc.Result1 = Calc.Addition(Calc.Result1, Calc.Result2);
                Result.Text = Calc.ReturnResult().ToString();
            }
            if (Calc.Operation == "-")
            {

                Calc.Result1 = Calc.Subtraction(Calc.Result2, Calc.Result1);
                Result.Text = Calc.ReturnResult().ToString();
            }
            if (Calc.Operation == "*")
            {

                Calc.Result1 = Calc.Multiply(Calc.Result1, Calc.Result2);
                Result.Text = Calc.ReturnResult().ToString();
            }
            if (Calc.Operation == "/")
            {

                Calc.Result1 = Calc.Divide(Calc.Result2, Calc.Result1);
                Result.Text = Calc.ReturnResult().ToString();
            }
            
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Calc.SetOperation("-");
            Calc.CopyResult();
            Calc.ClearResult();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            Calc.SetOperation("*");
            Calc.CopyResult();
            Calc.ClearResult();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Calc.SetOperation("/");
            Calc.CopyResult();
            Calc.ClearResult();
        }
    }
}
