using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _01_附加题_练习一
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                DateTime dateTime = DateTime.Now;
                label1.Text = dateTime.ToString("G");      
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
