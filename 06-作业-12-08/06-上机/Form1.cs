using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _06_上机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label2.Width += 5;
                label9.Text = (int.Parse(label9.Text) + 1).ToString();
            }
            if (radioButton2.Checked == true)
            {
                label4.Width += 5;
                label10.Text = (int.Parse(label10.Text) + 1).ToString();
            }
            if (radioButton3.Checked == true)
            {
                label6.Width += 5;
                label11.Text = (int.Parse(label11.Text) + 1).ToString();
            }
            if (radioButton4.Checked == true)
            {
                label8.Width += 5;
                label12.Text = (int.Parse(label12.Text) + 1).ToString();
            }
        }
    }
}
