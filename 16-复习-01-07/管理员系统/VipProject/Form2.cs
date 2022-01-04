using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string zhuangtai;
        private void 修改当前用户信息IToolStripMenuItem_Click(object sender, EventArgs e)
        {//修改当前用户信息
            zhuangtai = "修改";//传值
            Form3 from = new Form3();
            from.MdiParent = this;//位于父窗体之下
            from.Show();
        }

        private void 注册VIP用户LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zhuangtai = "添加";//传值
            Form3 from = new Form3();
            from.MdiParent = this;
            from.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否要退出?", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dr)
            {//退出系统
                Application.ExitThread();
            }
            else
            {//取消退出
                e.Cancel = true;
            }
        }
    }
}
