using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _01_课后
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("图片\\八神.jpg");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("八神"))
            {
                pictureBox1.BackgroundImage = Image.FromFile("图片\\八神.jpg");
            }
            if (comboBox1.Text.Equals("鬼神"))
            {
                pictureBox1.BackgroundImage = Image.FromFile("图片\\鬼神.jpg");
            }
            if (comboBox1.Text.Equals("火神"))
            {
                pictureBox1.BackgroundImage = Image.FromFile("图片\\火神.jpg");
            }
            if (comboBox1.Text.Equals("帅神"))
            {
                pictureBox1.BackgroundImage = Image.FromFile("图片\\帅神.jpg");
            }
        }
    }
}
