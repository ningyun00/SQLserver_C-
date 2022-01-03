using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _02_附加题_练习二
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int A = e.KeyValue;
            char CHAR = (char)A;
            if (CHAR == 'W' || CHAR == 'w')
            {
                pictureBox1.Image = Image.FromFile("图片\\w.png");
                pictureBox1.Top -= 5;

            }
            if (CHAR == 'S' || CHAR == 's')
            {
                pictureBox1.Image = Image.FromFile("图片\\s.png");
                pictureBox1.Top += 5;
            }
            if (CHAR == 'A' || CHAR == 'a')
            {
                pictureBox1.Image = Image.FromFile("图片\\a.png");
                pictureBox1.Left -= 5;
            }
            if (CHAR == 'D' || CHAR == 'd')
            {
                pictureBox1.Image = Image.FromFile("图片\\d.png");
                pictureBox1.Left += 5;
            }
            if (pictureBox1.Location.X > 403 || pictureBox1.Location.X < 0)
            {
                if (pictureBox1.Location.X < 0)
                {
                    pictureBox1.Left += 5;
                }
                if (pictureBox1.Location.X > 403)
                {
                    pictureBox1.Left -= 5;
                }
            }
            if (pictureBox1.Location.Y > 403 || pictureBox1.Location.Y < 0)
            {
                if (pictureBox1.Location.Y < 0)
                {
                    pictureBox1.Top += 5;
                }
                if (pictureBox1.Location.Y > 403)
                {
                    pictureBox1.Top -= 5;
                }
            }
/*            if (pictureBox1.Location.X >= 70 && pictureBox1.Location.X <= 131 && pictureBox1.Location.Y > 253 && pictureBox1.Location.Y <= 400)
            {
                if (pictureBox1.Location.X > 10)
                {
                    pictureBox1.Left -= 5;//左面墙
                }
            }
            if (pictureBox1.Location.X >= 70 && pictureBox1.Location.X <= 131 && pictureBox1.Location.Y > 253 && pictureBox1.Location.Y <= 400)
            {
                if (pictureBox1.Location.X >= 70)
                {
                    pictureBox1.Left += 10;//右面墙
                }
                //   MessageBox.Show("X：" + pictureBox1.Location.X.ToString() + "Y：" + pictureBox1.Location.Y.ToString());                  
            }
            if (pictureBox1.Location.X >= 70 && pictureBox1.Location.X <= 131 && pictureBox1.Location.Y > 253 && pictureBox1.Location.Y <= 400)
            {
                if (pictureBox1.Location.Y > 10)
                {
                    pictureBox1.Top -= 10;//左面墙
                }
            }*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
