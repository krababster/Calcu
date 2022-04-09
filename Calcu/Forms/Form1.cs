using System;
using Calcu.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleCalcBtn_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
          new Form3().ShowDialog(); 
        }
    }
}
