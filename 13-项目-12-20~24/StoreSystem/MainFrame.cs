using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreSystem
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void 商品类型管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "WareTypeForm")
                {//商品类型管理
                    item.BringToFront();
                    return;
                }
            }
            WareTypeForm wtf = new WareTypeForm();
            wtf.MdiParent = this;
            wtf.Show();
        }

        private void 添加商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "AddWareForm")
                {//添加商品
                    item.BringToFront();
                    return;
                }
            }
            AddWareForm awf = new AddWareForm();
            awf.MdiParent = this;
            awf.Show();
        }

        private void 商品信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "WareInfoMangeForm")
                {//商品信息维护
                    item.BringToFront();
                    return;
                }
            }
            WareInfoMangeForm wmf = new WareInfoMangeForm();
            wmf.MdiParent = this;
            wmf.Show();
        }

        private void 添加商品价格ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "AddWarePriceForm")
                {//添加商品价格，折扣
                    item.BringToFront();
                    return;
                }
            }
            AddWarePriceForm awp = new AddWarePriceForm();
            awp.MdiParent = this;
            awp.Show();
        }

        private void 商品价格信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "WarePriceManage")
                {//商品管理
                    item.BringToFront();
                    return;
                }
            }   
            WarePriceManage wpm = new WarePriceManage();
            wpm.MdiParent = this;
            wpm.Show();
        }

        private void 添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {//添加用户
                if (item.GetType().Name == "AddUserForm")
                {
                    item.BringToFront();
                    return;
                }
            }
            AddUserForm auf = new AddUserForm();
            auf.MdiParent = this;
            auf.Show();
        }

        private void 用户信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "UserInfoManage")
                {//用户信息维护
                    item.BringToFront();
                    return;
                }
            }
            UserInfoManage um = new UserInfoManage();
            um.MdiParent = this;
            um.Show();
        }

        private void 账单信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "AccountantbillManage")
                {//账单管理
                    item.BringToFront();
                    return;
                }
            }
            AccountantbillManage abm = new AccountantbillManage();
            abm.MdiParent = this;
            abm.Show();
        }

        private void 帮助文档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "help")
                {//账单管理
                    item.BringToFront();
                    return;
                }
            }
            help help = new help();
            help.MdiParent = this;
            help.Show();
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrame_FormClosing(object sender, FormClosingEventArgs e)
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

        private void 商品结算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "CustomerBalance")
                {//商品结算
                    item.BringToFront();
                    return;
                }
            }
            CustomerBalance cb = new CustomerBalance();
            cb.MdiParent = this;
            cb.Show();
        }

        private void 退出系统XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            LoginForm.A = 1;
            timer1.Start();
            toolStripStatusLabel2.Text = LoginForm.name;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            toolStripStatusLabel4.Text = dt.ToString("G");
        }
    }
}
