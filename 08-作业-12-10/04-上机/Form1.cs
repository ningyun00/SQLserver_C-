using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _04_上机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int A = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[A];
            A++;
            if (A > imageList1.Images.Count - 1)
            {
                A = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
