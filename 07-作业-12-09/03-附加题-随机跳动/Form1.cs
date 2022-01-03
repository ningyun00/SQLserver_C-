using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _03_附加题_随机跳动
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(random.Next(0,281),random.Next(0,259));
        }
    }
}
