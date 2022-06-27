using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tcalculator
{
    public partial class Form1 : Form
    {
        private double v1, v2, res;
        private int sel;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text =textBox1.Text+ "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void buttonPn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            Resta();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            Div();
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            Mult();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            Suma();
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            v2 = Convert.ToDouble(textBox1.Text);
            if (sel == 1)
            {
                res = v1 + v2;
                textBox1.Text = res.ToString();
            }else if(sel == 2)
            {
                res = v1 - v2;
                textBox1.Text = res.ToString();
            }else if(sel == 3)
            {
                try
                {
                    res = v1 / v2;
                    textBox1.Text = res.ToString();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }   
            }else if (sel == 4)
            {
                res = v1 * v2;
                textBox1.Text = res.ToString();
            }
           


        }

        private void Suma()
        {
            v1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            sel = 1;
        }

        private void Resta()
        {
            v1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            sel = 2;
        }

        private void Mult()
        {
            v1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            sel = 4;
        }

        private void Div()
        {
            v1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            sel = 3;
        }
    }
}
