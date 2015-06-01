using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Calc.Result = Convert.ToDouble(Calc.Result.ToString() + "1");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Two_Click(object sender, EventArgs e)
        {
            Calc.Result = Convert.ToDouble(Calc.Result.ToString() + "2");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Three_Click(object sender, EventArgs e)
        {
            Calc.Result = Convert.ToDouble(Calc.Result.ToString() + "3");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Four_Click(object sender, EventArgs e)
        {
            Calc.Result = Convert.ToDouble(Calc.Result.ToString() + "4");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Five_Click(object sender, EventArgs e)
        {
            Calc.Result = Convert.ToDouble(Calc.Result.ToString() + "5");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Six_Click(object sender, EventArgs e)
        {
            Calc.Result = Convert.ToDouble(Calc.Result.ToString() + "6");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            Calc.Result = Convert.ToDouble(Calc.Result.ToString() + "7");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            Calc.Result = Convert.ToDouble(Calc.Result.ToString() + "8");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            Calc.Result = Convert.ToDouble(Calc.Result.ToString() + "9");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            Calc.Result = Convert.ToDouble(Calc.Result.ToString() + "0");
            Result.Text = Calc.ReturnResult().ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Calc.ClearResult();
            Result.Text = Calc.ReturnResult().ToString();
        }
    }
}
