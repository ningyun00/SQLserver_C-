using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _01_作业_练习一
{
    public partial class Form01 : Form
    {
        public Form01()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("图片\\01.png");
            pictureBox2.Image = Image.FromFile("图片\\02.png");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            pictureBox2.Left += 5;
            if (pictureBox1.Location.X<=0)
            {
                timer1.Stop();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
