using System;
using System.Windows.Forms;

namespace Calcu.Forms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dist = 0, averCons = 0, price = 0, fuelValue, tripcost;
            if (textBox1.Text != string.Empty)
                dist = double.Parse(textBox1.Text);
            if (textBox2.Text != string.Empty)
                averCons = double.Parse(textBox2.Text);
            if (textBox3.Text != string.Empty)
                price = double.Parse(textBox3.Text);

            fuelValue = dist / averCons;
            tripcost = fuelValue * price;

            if (averCons <= 0)
            {
                textBox2.Text = "Введите число больше нуля!";
                textBox4.Text = "NaN";
                textBox5.Text = "NaN";
            }
            else if (textBox1.Text != string.Empty & textBox2.Text != string.Empty & textBox3.Text != string.Empty)
            {
               if(fuelValue.ToString().Length >=4 & tripcost.ToString().Length >= 4)
                {
                    textBox4.Text = fuelValue.ToString().Substring(0,5);
                    textBox5.Text = tripcost.ToString().Substring(0,5);
                }
               else
                {
                    textBox4.Text = fuelValue.ToString();
                    textBox5.Text = tripcost.ToString();
                }
            }
            else if (textBox1.Text == string.Empty & textBox2.Text == string.Empty & textBox3.Text == string.Empty)
            {
                textBox4.Text = "NaN";
                textBox5.Text = "NaN";
            }
            else if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                textBox4.Text = "NaN";
                textBox5.Text = "NaN";
            }
            else if (textBox3.Text == string.Empty)
            {
                textBox4.Text = fuelValue.ToString().Substring(0, 5);
                textBox5.Text = "NaN";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double fuelValue = 0;
            double dist = 0;
            if (textBox6.Text != string.Empty)
                fuelValue = double.Parse(textBox6.Text);
            if (textBox7.Text != string.Empty)
                dist = double.Parse(textBox7.Text);
            double averCons = fuelValue / dist * 100;

            if (dist <= 0)
            {
                textBox7.Text = "Введите число больше нуля!";
                label17.Text = "Ошибка!";
            }
            else if(averCons.ToString().Length >= 4)
                label17.Text = $"Расход топлива вашего авто составляет {averCons.ToString().Substring(0, 5)} литров на 100 км.";
            else
                label17.Text = $"Расход топлива вашего авто составляет {averCons} литров на 100 км.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double averCons = 0;
            double factFuelValue = 0;

            if (textBox8.Text != string.Empty)
                averCons = double.Parse(textBox8.Text);
            if (textBox9.Text != string.Empty)
                factFuelValue = double.Parse(textBox9.Text);

            double dist = factFuelValue / averCons * 100;
            if (averCons <= 0)
            {
                textBox8.Text = "Введит ечисло больше нуля";
                label23.Text = "Ошибка!";
            }
            else if(dist.ToString().Length >=4)
                label23.Text = $"Вы сможете проехать {dist.ToString().Substring(0, 5)} км.";
            else
                label23.Text = $"Вы сможете проехать {dist} км.";

        }
    }
}
