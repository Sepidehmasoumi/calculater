using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        bool plus = false, mines = false, equals = false, devide = false, percent = false, multipication = false;
        double result1, result2;

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text += ".";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            result1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            plus = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(plus == true)
            {
                result2 = Convert.ToDouble(textBox1.Text);
                double my_result = result1 + result2;
                textBox1.Text = my_result.ToString();
                plus = false;
            }
            else if (mines == true)
            {
                result2 = Convert.ToDouble(textBox1.Text);
                double my_result = result1 - result2;
                textBox1.Text = my_result.ToString();
                mines = false;
            }
            else if (multipication == true)
            {
                result2 = Convert.ToDouble(textBox1.Text);
                double my_result = result1 * result2;
                textBox1.Text = my_result.ToString();
                multipication = false;
            }
            else if (devide == true)
            {
                result2 = Convert.ToDouble(textBox1.Text);
                double my_result = result1 / result2;
                textBox1.Text = my_result.ToString();
                devide = false;
            }
            else if (percent == true)
            {
                result2 = Convert.ToDouble(textBox1.Text);
                double my_result = result1 % result2;
                textBox1.Text = my_result.ToString();
                percent = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            result1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            mines = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            result1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            multipication = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            devide = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            result1 = 0;
            result2 = 0;
            textBox1.Text = "0";
            devide = false;
            multipication = false;
            plus = false;
            mines = false;
            percent = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            result1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            percent = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
         if(textBox1.Text != "0")
            {
                textBox1.Text =  textBox1.Text.Remove(textBox1.TextLength - 1);
            }
            }
            catch (Exception)
            {

            }
        }

        private void numbers(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += ((Button)sender).Text.ToString();
            }
            else
            {
                textBox1.Text = ((Button)sender).Text.ToString();
            }
        }

        double lastest_result;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            result1 = 0;
            result2 = 0;
            textBox1.Text = "0";
            devide = false;
            multipication = false;
            plus = false;
            mines = false;
            percent = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
