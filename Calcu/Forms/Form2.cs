using System;
using System.Windows.Forms;

namespace Calcu.Forms
{

    public partial class Form2 : Form
    {
        float a = 0, b = 0;
        char myChar;

        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "1";
            textBox1.Text = textBox1.Text + "1";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "2";
            textBox1.Text = textBox1.Text + "2";
        }


        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            label2.Text = label2.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4"; 
            label2.Text = label2.Text + "4";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            label2.Text = label2.Text + "5";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            label2.Text = label2.Text + "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            label2.Text = label2.Text + "7";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            label2.Text = label2.Text + "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            label2.Text = label2.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            label2.Text = label2.Text  + '+';
            textBox1.Text = "+";
            myChar = '+';
            textBox1.Text = String.Empty;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            label2.Text = label2.Text + '-';
            textBox1.Text = "-";
            myChar = '-'; ;
            textBox1.Text = String.Empty;
        }


        private void button11_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            label2.Text = label2.Text + '*';
            textBox1.Text = "*";
            myChar = 'x';
            textBox1.Text = String.Empty;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            label2.Text = label2.Text + '/';
            textBox1.Text = "/";
            myChar = '/';
            textBox1.Text = String.Empty;
        }
        private void button23_Click(object sender, EventArgs e)
        {
            Calculate();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ',';
        }


        public void Calculate()
        {
            if (myChar == '+')
            {
                b = a  + float.Parse(textBox1.Text);
                textBox1.Text = b.ToString();
                label2.Text = label2.Text + '=' + b;
            }
            else if (myChar == '-')
            {
                b =a - float.Parse(textBox1.Text);
                textBox1.Text = b.ToString();
                label2.Text = label2.Text + '=' + b;
            }
            else if (myChar == 'x')
            {
                b = a * float.Parse(textBox1.Text);
                textBox1.Text = b.ToString();
                label2.Text = label2.Text + '=' + b;
            }
            else if (myChar == '/')
            {
                b = a / float.Parse(textBox1.Text);
                textBox1.Text = b.ToString();
                label2.Text = label2.Text + '=' + b;
            }
        }

    }
}
