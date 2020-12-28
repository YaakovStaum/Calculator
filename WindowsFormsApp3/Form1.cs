using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string digits = "digit1";
        string _FirstDigit;
        string _SecondDigit = " ";
        string function;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            button20.Text = button20.Text + b.Text;
            if (digits == "digit1")
            {
                _FirstDigit = _FirstDigit + b.Text;
            }
            else
            {
                _SecondDigit = _SecondDigit + b.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            button20.Text = button20.Text + b.Text;
            
            digits = "digit2";
            function = b.Text;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (_SecondDigit == " ")
            {
                
            }
            else
            {


                double FirstDigit = double.Parse(_FirstDigit);
                double SecondDigit = double.Parse(_SecondDigit);
                if (function == "+")
                {
                    result = FirstDigit + SecondDigit;
                }
                if (function == "-")
                {
                    result = FirstDigit - SecondDigit;
                }
                if (function == "*")
                {
                    result = FirstDigit * SecondDigit;
                }
                if (function == "/")
                {
                    result = FirstDigit / SecondDigit;
                }
                string _result = result.ToString();

                button20.Text = _result;

                _FirstDigit = _result;
                _SecondDigit = " ";
            }

        }
    }
}
