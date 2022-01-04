using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 图书管理系统
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nun_null())
            {
                Login1();
            }
        }

        private bool nun_null()
        {
            if (textBox1.Text == string.Empty)
            {//用户名为空
                MessageBox.Show("请输入用户名", "系统提示");
                return false;
            }
            if (textBox2.Text == string.Empty)
            {//密码为空
                MessageBox.Show("请输入密码", "系统提示");
                return false;
            }
            return true;
        }//为空判断
        //登录验证
        public void Login1()
        {
            if (radioButton1.Checked == true)
            {//普通用户
                Dao dao = new Dao();
                string sql = string.Format("select * from [User] where [Uname] = '{0}' and [Upwd] = '{1}'", textBox1.Text, textBox2.Text);
                IDataReader idr = dao.read(sql);
                if (idr.Read())
                {
                    MessageBox.Show("登陆成功", "系统提示");
                }
                else
                {
                    MessageBox.Show("登陆失败", "系统提示");
                }
                dao.DaoClose();
            }
            if (radioButton2.Checked == true)
            {//管理员
                Dao dao = new Dao();
                string sql = string.Format("select * from [Administrator] where [Aname] = '{0}' and [Apwd] = '{1}'", textBox1.Text, textBox2.Text);//三种方法
                IDataReader idr = dao.read(sql);//返回受影响的行数
                if (idr.Read())
                {
                    MessageBox.Show("登陆成功", "系统提示");
                }
                else
                {
                    MessageBox.Show("登陆失败", "系统提示");
                }
                dao.DaoClose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
