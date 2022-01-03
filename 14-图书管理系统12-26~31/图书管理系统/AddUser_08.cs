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
    public partial class AddUser_08 : Form
    {
        public AddUser_08()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.;uid=sa;pwd=123456;database=Book");

        Random rd = new Random();

        string no = null;

        public static int num;

        private void AddUser_08_Load(object sender, EventArgs e)
        {
            yanzhengma();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("再次输入密码错误", "系统提示");
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {//查询重复用户名
            chaxunchongfuyonghuming();
        }//普通用户

        private void button1_Click(object sender, EventArgs e)
        {
            if (nun_null())
            {
                if (num == 0)
                {
                    tianjia();
                    login login1 = new login();
                    login1.Show();
                    this.Hide();
                }
                else
                {
                    if (textBox4.Text == label5.Text || textBox4.Text.Trim().ToLower() == label5.Text.ToLower())
                    {
                        tianjia();
                    }
                    else
                    {
                        MessageBox.Show("验证码错误", "系统提示", MessageBoxButtons.OK);
                        textBox4.Text = string.Empty;
                        yanzhengma();
                    }
                }
            }
        }

        private void yanzhengma()
        {
            char no1 = (char)rd.Next(65, 91);
            char no2 = (char)rd.Next(65, 91);
            char no3 = (char)rd.Next(65, 91);
            char no4 = (char)rd.Next(65, 91);
            no = no1.ToString();
            no = no + no2.ToString();//拼接
            no = no + no3.ToString();
            no = no + no4.ToString();
            label5.Text = no;
        }

        private bool nun_null()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请输入用户名", "系统提示");
                return false;
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("请输入密码", "系统提示");
                return false;
            }
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("请再次输入密码", "系统提示");
                return false;
            }
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("请输入验证码", "系统提示");
                return false;
            }
            return true;
        }

        private void tianjia()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("insert into [User] values('{0}','{1}')", textBox1.Text.Trim(), textBox3.Text.Trim());
                    SqlCommand com = new SqlCommand(sql, con);
                    if (com.ExecuteNonQuery() > 0)
                    {
                        if (num == 0)
                        {
                            MessageBox.Show("添加成功。用户名：" + textBox1.Text.Trim() + "密码：" + textBox3.Text.Trim(), "系统提示");
                        }
                        else
                        {
                            MessageBox.Show("添加成功", "系统提示");
                        }
                    }
                    else
                    {
                        MessageBox.Show("添加失败", "系统提示");
                    }
                }
                else
                {
                    MessageBox.Show("数据库未打开", "系统提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }//添加

        private void chaxunchongfuyonghuming()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select [Uid],[Uname],[Upwd] from [User] where [Uname] = '{0}'", textBox1.Text.Trim());
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader sdr = com.ExecuteReader();
                    if (sdr.Read())
                    {//找到用户
                        MessageBox.Show("已有（" + textBox1.Text.Trim() + "）普通用户", "系统提示", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("数据库未打开", "系统提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }//查询重复普通用户名

        private void button2_Click(object sender, EventArgs e)
        {
            if (num == 0)
            {
                if (MessageBox.Show("确定取消添加吗?", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    login login1 = new login();
                    login1.Show();
                    this.Hide();
                }
            }
            if (num == 1)
            {
                Close();
            }

        }

        private void AddUser_08_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (num == 0)
            {
                if (MessageBox.Show("确定退出系统吗?", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (num == 0)
                    {
                        Application.ExitThread();
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

