using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 员工管理系统
{
    public partial class frmStaffHomepage : Form
    {


        public frmStaffHomepage()
        {
            InitializeComponent();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "frmStaffAlterCode")
                {
                    item.BringToFront();
                    return;
                }
            }
            frmStaffAlterCode StaffAlterCode = new frmStaffAlterCode();
            StaffAlterCode.MdiParent = this;
            StaffAlterCode.Show();
        }
        private void 员工列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "frmStaffEntry")
                {
                    item.BringToFront();
                    return;
                }
            }
            frmStaffEntry staffEntry = new frmStaffEntry();
            staffEntry.MdiParent = this;
            staffEntry.Show();
        }
        public int tianjia00;
        private void 添加员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "frmStaffAddAlter")
                {
                    item.BringToFront();
                    return;
                }
            }
            frmStaffAddAlter staffAddAlter = new frmStaffAddAlter();
            staffAddAlter.MdiParent = this;
            tianjia00 = 0;
            staffAddAlter.Show();
        }
        public int zhi;//值

        private void 部门列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "frmClassEntry")
                {
                    item.BringToFront();
                    return;
                }
            }
            frmClassEntry classEntry = new frmClassEntry();
            classEntry.MdiParent = this;
            classEntry.Show();
        }


        private void 添加部门ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "frmClassAddAlter")
                {
                    item.BringToFront();
                    return;
                }
            }
            frmClassAddAlter classAddAlter = new frmClassAddAlter();
            classAddAlter.MdiParent = this;
            zhi = 1;//值==添加
            classAddAlter.Show();
        }

        private void 关于我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "frmAboutWe")
                {
                    item.BringToFront();
                    return;
                }
            }
            frmAboutWe aboutWe = new frmAboutWe();
            aboutWe.MdiParent = this;
            aboutWe.Show();
        }
        /// <summary>
        /// 员工查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "frmStaffEntry")
                {
                    item.BringToFront();
                    return;
                }
            }
            frmStaffEntry staffEntry = new frmStaffEntry();
            staffEntry.MdiParent = this;
            staffEntry.Show();
        }
        /// <summary>
        /// 部门查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "frmClassEntry")
                {
                    item.BringToFront();
                    return;
                }
            }
            frmClassEntry classEntry = new frmClassEntry();
            classEntry.MdiParent = this;
            classEntry.Show();
        }
        private void frmStaffHomepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
       
        }

        private void 员工管理MToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
