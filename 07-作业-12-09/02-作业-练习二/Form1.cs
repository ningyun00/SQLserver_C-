using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _02_作业_练习二
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("图片\\01.png");
            pictureBox2.Image = Image.FromFile("图片\\02.png");
        }
        /// <summary>
        /// 计时器事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //左下角移动
            pictureBox1.Left -= 5;
            pictureBox1.Top += 5;
            pictureBox2.Left += 5;
            pictureBox2.Top += 5;
            if (pictureBox1.Location.Y>222)
            {
                timer1.Stop();
            }
        }
    }
}
