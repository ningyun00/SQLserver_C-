using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _04_作业_练习四
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        /// <summary>
        /// 结束
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = random.Next(0, 10).ToString();
            label2.Text = random.Next(0, 10).ToString();
            label3.Text = random.Next(0, 10).ToString();
            label4.Text = random.Next(0, 10).ToString();
            label5.Text = random.Next(0, 10).ToString();
            label6.Text = random.Next(0, 10).ToString();
            if (label1.Text == label2.Text)
            {
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Green;
            }
            else if (label3.Text == label4.Text)
            {
                label3.ForeColor = Color.HotPink;
                label4.ForeColor = Color.Salmon;
            }
            else if (label4.Text == label5.Text)
            {
                label5.ForeColor = Color.GreenYellow;
            }
            else if (label6.Text == label1.Text)
            {
                label6.ForeColor = Color.Firebrick;
            }
            else
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
            }
        }
    }
}
