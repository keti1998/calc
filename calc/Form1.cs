using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        double firstNumber;
        string opr;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text ="7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "";
            opr = "add";
            button16.Enabled = true;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            double secondNumber;
           
            if (!double.TryParse(textBox1.Text, out secondNumber))
            {
                textBox1.Text = "";
                //обработка, если не число 
            }
            secondNumber = double.Parse(textBox1.Text);
            double result;
            if (opr == "add")
            {
                result = firstNumber + secondNumber;
                textBox1.Text = Convert.ToString(result);
                firstNumber = 0;
            }
            else if (opr == "minus")
            {
                result = firstNumber - secondNumber;
                textBox1.Text = Convert.ToString(result);
                firstNumber = 0;
            }
            else if (opr == "mult")
            {
                result = firstNumber * secondNumber;
                textBox1.Text = Convert.ToString(result);
                firstNumber = 0;
            }
            else if (opr == "div")
            {

                result = firstNumber / secondNumber;
                textBox1.Text = Convert.ToString(result);
                firstNumber = 0;

            }
            else if (opr == "exp")
            {
                result = firstNumber;
                for (int i = 0; i <secondNumber-1; i++)
                {
                    result = result*firstNumber;
                    textBox1.Text = Convert.ToString(result);

                }

                firstNumber = 0; 
            }


        }

        private void button12_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "";
            opr = "minus";
            button16.Enabled = true;


        }

        private void button14_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "";
            opr = "mult";
            button16.Enabled = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "";
            opr = "div";
            button16.Enabled = true;
        }


        private void button16_Click(object sender, EventArgs e)
        {
            bool check;
            button16.Enabled = false;

            check = int.TryParse(textBox1.Text, out int  s);
            if(check)
            {
                textBox1.Text += ".";
                firstNumber = double.Parse(textBox1.Text);
            }
       else
            {
                button16.Enabled = false;
            }
            

        }

        private void button17_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "";
            opr = "exp";
            button16.Enabled = true;
        }
    }
}
