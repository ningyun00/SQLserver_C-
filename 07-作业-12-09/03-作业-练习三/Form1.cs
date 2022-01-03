using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _03_作业_练习三
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime dateTime = DateTime.Now;
        int A = 9;
        private void timer1_Tick(object sender, EventArgs e)
        {

            label3.Text = dateTime.ToString("HH:mm:ss");
            if (A >= 0)
            {
                label2.Text = A.ToString();
                label2.ForeColor = Color.Red;
                A--;
            }
            if (A < 0)
            {
                A = 9;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (label2.Text == textBox1.Text)
            {
                MessageBox.Show("猜中了", "猜数字");
            }
            else
            {
                MessageBox.Show("猜错了", "猜数字");
            }
        }
    }
}
