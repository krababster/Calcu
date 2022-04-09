using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcu.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            label2.Text = label2.Text+ textBox1.Text;
            textBox1.Text = "";

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
            label2.Text = label2.Text + textBox1.Text;
            textBox1.Text = "";
        }


        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            label2.Text = label2.Text + textBox1.Text;
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            label2.Text = label2.Text + textBox1.Text;
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            label2.Text = label2.Text + textBox1.Text;
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            label2.Text = label2.Text + textBox1.Text;
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            label2.Text = label2.Text + textBox1.Text;
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            label2.Text = label2.Text + textBox1.Text;
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            label2.Text = label2.Text + textBox1.Text;
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
            label2.Text = label2.Text + textBox1.Text;
            textBox1.Text = "";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
            label2.Text = label2.Text + textBox1.Text;
            textBox1.Text = "";
        }


        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "x";
            label2.Text = label2.Text + textBox1.Text;
            textBox1.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
            label2.Text = label2.Text + textBox1.Text;
            textBox1.Text = "";
        }
        private void button23_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "=";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
    }
}
