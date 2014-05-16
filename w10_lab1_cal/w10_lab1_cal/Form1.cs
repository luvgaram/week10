using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w10_lab1_cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double num = 0, sum = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            num = num * 10 + 1;
            button14.Text = num.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num = num * 10 + 2;
            button14.Text = num.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num = num * 10 + 3;
            button14.Text = num.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num = num * 10 + 4;
            button14.Text = num.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num = num * 10 + 5;
            button14.Text = num.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num = num * 10 + 6;
            button14.Text = num.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num = num * 10 + 7;
            button14.Text = num.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num = num * 10 + 8;
            button14.Text = num.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num = num * 10 + 9;
            button14.Text = num.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num = num * 10;
            button14.Text = num.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            sum = sum + num;
            button14.Text = "+";
            num = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sum = sum + num;
            button14.Text = sum.ToString();
            num = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sum = 0;
            num = 0;
            button14.Text = "0";
        }
    }
}
