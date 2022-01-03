using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _09_04_作业
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fA = new Form1();
            this.Hide();
            if (this.textBox1.Text == "admin" && this.textBox2.Text == "0000")
            {
                DialogResult dialogResult = MessageBox.Show("恭喜你登录成功","登陆成功",MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("登陆失败", "登陆失败", MessageBoxButtons.RetryCancel);
                if (dialogResult==DialogResult.Retry)
                {
                    Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
