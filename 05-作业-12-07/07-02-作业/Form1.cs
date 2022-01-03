using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _07_02_作业
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogResult dialogResult = MessageBox.Show("和我去打篮球吗？","提示",MessageBoxButtons.YesNo);
            if (dialogResult==DialogResult.Yes)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }

        }
    }
}
