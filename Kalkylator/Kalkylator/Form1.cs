using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkylator
{
    public partial class Form1 : Form
    {
        string Input = string.Empty;
        string num1 = string.Empty;
        string num2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zero_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            Input += "0";
            this.textBox1.Text += Input;

        }

        private void One_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            Input += "1";
            this.textBox1.Text += Input;
        }

        private void Two_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            Input += "2";
            this.textBox1.Text += Input;
        }

        private void Three_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            Input += "3";
            this.textBox1.Text += Input;
        }

        private void Four_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            Input += "4";
            this.textBox1.Text += Input;
        }

        private void Five_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            Input += "5";
            this.textBox1.Text += Input;
        }

        private void Six_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            Input += "6";
            this.textBox1.Text += Input;
        }

        private void Seven_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            Input += "7";
            this.textBox1.Text += Input;
        }

        private void Eight_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            Input += "8";
            this.textBox1.Text += Input;
        }

        private void Nine_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            Input += "9";
            this.textBox1.Text += Input;
        }

        private void Addition_MouseClick(object sender, MouseEventArgs e)
        {
            num1 = Input;
            operation = Convert.ToChar("+");
            Input = string.Empty;
        }

        private void Subtract_MouseClick(object sender, MouseEventArgs e)
        {
            num1 = Input;
            operation = Convert.ToChar("-");
            Input = string.Empty;
        }

        private void Multiply_MouseClick(object sender, MouseEventArgs e)
        {
            num1 = Input;
            operation = Convert.ToChar("*");
            Input = string.Empty;
        }

        private void Division_MouseClick(object sender, MouseEventArgs e)
        {
            num1 = Input;
            operation = Convert.ToChar("÷");
            Input = string.Empty;
        }

        private void Equal_MouseClick(object sender, MouseEventArgs e)
        {
            
            double Num1, Num2;
            double.TryParse(num1, out Num1);
            double.TryParse(num2, out Num2);

            if (operation == '+')
            {
                result = Num1 + Num2;
                textBox1.Text = result.ToString();
            }

            else if (operation == '-')
            {
                result = Num1 - Num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = Num1 - Num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '÷')
            {
                if (Num2 != 0)
                {
                    result = Num1 / Num2;
                    textBox1.Text = result.ToString();

                }
                else
                {
                    textBox1.Text = "Can't divide by 0";
                }

            }
        }

        private void Clear_MouseClick(object sender, MouseEventArgs e)
        {
            this.Input = string.Empty;
            this.num1 = string.Empty;
            this.num2 = string.Empty;
            this.textBox1.Text = string.Empty;


        }

        private void Decimal_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            Input += ",";
            this.textBox1.Text += Input;
        }
    }
}