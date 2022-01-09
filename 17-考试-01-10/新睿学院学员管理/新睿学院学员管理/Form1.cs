using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 新睿学院学员管理
{
    public partial class FrmEmpSysMain : Form
    {
        public FrmEmpSysMain()
        {
            InitializeComponent();
        }

        private void 添加学员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void 查询学员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }

        private void FrmEmpSysMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否要退出？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
