using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _11_06_作业
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int A = 2000;
        private void button1_Click(object sender, EventArgs e)
        {
            if (A >= 2000 && A < 2012)
            {
                A++;
            }
            else
            {
                A = 2000;
            }
            textBox1.Text = Convert.ToString(A);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (A>2000&&A<=2012)
            {
                A--;
            }
            else
            {
                A = 2012;
            }
            textBox1.Text = Convert.ToString(A);
        }
    }
}
