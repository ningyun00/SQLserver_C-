using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _08_03_作业
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int A = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (A >= 1 && A < 10)
            {
                A++;
            }
            else
            {
                A = 1;
            }
            label2.Text = Convert.ToString(A);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (A <= 1)
            {
                A = 10;
            }
            else
            {
                A--;
            }
            label2.Text = Convert.ToString(A);
        }
    }
}
