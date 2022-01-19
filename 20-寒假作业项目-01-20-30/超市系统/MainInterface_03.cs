using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 超市系统
{
    public partial class MainInterface_03 : Form
    {
        public MainInterface_03()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 创建对象
        /// </summary>
        LoginPage_01 loginPage = new LoginPage_01();

        private void pictureBox1_Click(object sender, EventArgs e)
        {//商品管理
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "shangPinGuanLi_04")
                {
                    MessageBox.Show("该窗体已打开", "系统提示");
                    item.BringToFront();
                    return;
                }
            }
            shangPinGuanLi_04 shangPinGuanLi = new shangPinGuanLi_04
            {
                MdiParent = this
            };
            shangPinGuanLi.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {//商品类型管理

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {//会员管理

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {//供货商管理

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {//注册用户

        }

        private void MainInterface_03_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否要退出", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MainInterface_03_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Class1.state;
            toolStripStatusLabel4.Text = Class1.name;
        }
    }
}
