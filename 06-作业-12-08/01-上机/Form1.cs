using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _01_上机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                MessageBox.Show("还没吃饭","吃饭了没?");
            }
            if (radioButton2.Checked==true)
            {
                MessageBox.Show("已吃了饭", "吃饭了没?");
            }
        }
    }
}
