using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class Homepage_02 : Form
    {
        public Homepage_02()
        {
            InitializeComponent();
        }

        DateTime dt = DateTime.Now;

        public void jiazai()
        {
            toolStripStatusLabel2.Text = Data.name;
            toolStripStatusLabel4.Text = Data.state;
          
        }

        private void Homepage_02_Load(object sender, EventArgs e)
        {
            AddUser_08.num = 1;
            jiazai();
            toolStripStatusLabel5.Text = dt.ToString();
            if (Data.state == "管理员")
            {
                用户权限修改TToolStripMenuItem.Visible = true;
                图书借阅ToolStripMenuItem.Visible = true;
                添加管理员用户EToolStripMenuItem.Visible = true;
                图书归还ToolStripMenuItem.Visible = true;
            }
            else
            {
                用户权限修改TToolStripMenuItem.Visible = false;
                图书借阅ToolStripMenuItem.Visible = false;
                添加管理员用户EToolStripMenuItem.Visible = false;
                图书归还ToolStripMenuItem.Visible = false;
            }
        }

        private void 用户权限修改TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == " AddUserAdministrator_10")
                {//图书管理
                    item.BringToFront();
                    return;
                }
            }
            AddUserAdministrator_10 addUserAdministrator = new AddUserAdministrator_10();
            addUserAdministrator.MdiParent = this;
            addUserAdministrator.Show();
        }

        private void Homepage_02_FormClosing(object sender, FormClosingEventArgs e)
        {//退出判断
            if (MessageBox.Show("确定要退出吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void 图书借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == " BorrowBook_05")
                {//图书管理
                    item.BringToFront();
                    return;
                }
            }
            BorrowBook_05 borrowBook = new BorrowBook_05();
            borrowBook.MdiParent = this;
            borrowBook.Show();
        }

        private void 图书管理PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == " Librarian_03")
                {//图书管理
                    item.BringToFront();
                    return;
                }
            }
            Librarian_03 librarian = new Librarian_03();
            librarian.MdiParent = this;
            librarian.Show();
        }

        private void 图书归还ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "ReturnBook_07")
                {//图书管理
                    item.BringToFront();
                    return;
                }
            }
            ReturnBook_07 returnBook = new ReturnBook_07();
            returnBook.MdiParent = this;
            returnBook.Show();
        }

        private void 添加普通用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "AddUser_08")
                {//图书管理
                    item.BringToFront();
                    return;
                }
            }
            AddUser_08 addUser = new AddUser_08();
            addUser.MdiParent = this;
            addUser.Show();
        }

        private void 添加管理员用户EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.state == "管理员")
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (item.GetType().Name == "AddAdministrator_09")
                    {//图书管理
                        item.BringToFront();
                        return;
                    }
                }
                AddAdministrator_09 addAdministrator = new AddAdministrator_09();
                addAdministrator.MdiParent = this;
                addAdministrator.Show();
            }
            else
            {
                MessageBox.Show("您的权限不够请联系管理员(3174902862@qq.com)", "系统提示");
            }
        }

        private void 添加图书IToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 退出系统OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "ChangePassword_11")
                {//添加图书
                    item.BringToFront();
                    return;
                }
            }
            ChangePassword_11 changePassword = new ChangePassword_11();
            changePassword.MdiParent = this;
            changePassword.Show();
        }

        private void 添加图书IToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "AddBock_04")
                {//添加图书
                    item.BringToFront();
                    return;
                }
            }
            AddBock_04 addBock = new AddBock_04();
            Data.bianhao = 0;
            addBock.MdiParent = this;
            addBock.Show();
        }

        private void 我的书架ZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "MyBookrack_12")
                {//我的书架
                    item.BringToFront();
                    return;
                }
            }
            MyBookrack_12 myBookrack  = new MyBookrack_12();
            myBookrack.MdiParent = this;
            myBookrack.Show();
        }
    }
}
