using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _13_02_附加题
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (textBox1.Text == "123456" && textBox2.Text == "qazwsx")
            {
                DialogResult dialogResult = MessageBox.Show("登陆成功","登陆成功",MessageBoxButtons.OK);
                if (dialogResult==DialogResult.OK)
                {
                    Application.Exit();
                }
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
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
