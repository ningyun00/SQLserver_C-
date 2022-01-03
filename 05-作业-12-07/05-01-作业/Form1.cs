using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _05_01_作业
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int A = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (A == 0)
            {
                this.Text = "寜";
                button1.BackColor = Color.Red;
                A = 1;
            }
            else
            {
                this.Text = "From1";
                button1.BackColor = Color.White;
                A = 0;
            }
        }
    }
}
