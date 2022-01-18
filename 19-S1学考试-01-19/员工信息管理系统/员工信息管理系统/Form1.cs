using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 员工信息管理系统
{
    public partial class frmEmploeeSySMain : Form
    {
        public frmEmploeeSySMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 添加员工
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 添加员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            //创建窗体对象
            form2.MdiParent = this;
            //继承于Form1窗体
            form2.Show();
            //弹出Form2窗体
        }
        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要退出系统", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {//判断是否退出
                Application.Exit();
                //退出
            }
        }
    }
}
