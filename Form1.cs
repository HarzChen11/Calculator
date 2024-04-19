using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.計算機
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string number1, number2;
        string oper = "";

        private void numberClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            resultTxt.Text += button.Text;
        }

        private void equalClick(object sender, EventArgs e)
        {
            number2 = resultTxt.Text;
            Calc calc = new Calc();
            calc.Number1 = number1;
            calc.Number2 = number2;
            calc.Oper = oper;
            //calc.Test = "test";
            //calc.number1 = 0;
            //calc.number2 = 0;
            //calc.oper = "";
            resultTxt.Text = calc.ResultTxt;
        }

        private void clearClick(object sender, EventArgs e)
        {
            number1 = "";
            number2 = "";
            oper = "";
            resultTxt.Text = "";
        }

        private void operClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            oper = button.Text;
            number1 = resultTxt.Text;
            resultTxt.Text = "";
        }
    }
}
