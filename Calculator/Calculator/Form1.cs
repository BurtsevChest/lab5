using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a, b;
        char operation;
        bool f = true;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        //очистка
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            f = true;
        }
        //вывод
        private void button12_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            double res = 0;
            if (operation == '+')
            {
                res = a + b;
            }
            if (operation == '-')
            {
                res = a - b;
            }
            if (operation == '*')
            {
                res = a * b;
            }

            if (operation == '/')
            {
                if (b != 0)
                    res = a / b;
                else
                    MessageBox.Show("Дубень ты конечно!");
            }
            textBox1.Text = Convert.ToString(res);
            f = true;
        }
        //вычитание
        private void button14_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            operation = '-';
            textBox1.Text = " ";
            f = true;
        }
        //умножение
        private void button15_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            operation = '*';
            textBox1.Text = " ";
            f = true;
        }
        //деление
        private void button16_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            operation = '/';
            textBox1.Text = " ";
            f = true;
        }
        //точка
        
        private void button17_Click(object sender, EventArgs e)
        {
            if (f)
            { textBox1.Text += ",";
                f = false;
                    }
        } 

        //сложение
        private void button13_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            operation = '+';
            textBox1.Text = " ";
            f = true;
        }

       
    }
}
