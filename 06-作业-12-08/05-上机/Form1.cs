using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _05_上机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && radioButton3.Checked == true)
            {
                MessageBox.Show("天分" + radioButton1.Text +"付出"+ radioButton3.Text, "选择");
            }
            if (radioButton1.Checked == true && radioButton4.Checked == true)
            {
                MessageBox.Show("天分" + radioButton1.Text + "付出" + radioButton4.Text, "选择");
            }
            if (radioButton2.Checked == true && radioButton3.Checked == true)
            {
                MessageBox.Show("天分" + radioButton2.Text + "付出" + radioButton3.Text, "选择");
            }
            if (radioButton2.Checked == true && radioButton4.Checked == true)
            {
                MessageBox.Show("天分" + radioButton2.Text + "付出" + radioButton4.Text, "选择");
            }
        }
    }
}
