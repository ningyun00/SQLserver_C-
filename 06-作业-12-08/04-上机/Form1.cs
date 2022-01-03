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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

            int C;
        private void button1_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(textBox1.Text);
            int B = Convert.ToInt32(textBox2.Text);
            if (comboBox1.Text.Equals("+"))
            {
                C = A + B;
            }
            if (comboBox1.Text.Equals("-"))
            {
                C = A - B;
            }
            if (comboBox1.Text.Equals("*"))
            {
                C = A * B;
            }
            if (comboBox1.Text.Equals("/"))
            {
                C = A / B;
            }
            textBox3.Text = C.ToString();
        }
    }
}
