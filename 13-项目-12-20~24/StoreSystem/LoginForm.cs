using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StoreSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private bool panduan()
        {//判断登录是否为空
            if (txtUserName.Text.Trim() == string.Empty)
            {//用户为空
                MessageBox.Show("用户名不能为空", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtUserPwd.Text.Trim() == string.Empty)
            {//密码为空
                MessageBox.Show("密码不能为空", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入验证码", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;//都不为空
        }//登录判断
        public static string name;
        private void userName()
        {//用户名查找
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("server=.;uid=sa;pwd=123456;database=StoreSystem;");
                //连接数据库
                con.Open();
                if (con.State == ConnectionState.Open)
                {//打开数据库
                    string sql = string.Format("select * from UserInfo where userName = '{0}'", txtUserName.Text.Trim());
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {//找到用户                        
                    }
                    else
                    {
                        MessageBox.Show("未找到该用户", "系统提示", MessageBoxButtons.OK);
                    }
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
        }//用户名
        private void userPwd()
        {//用户密码
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("server=.;uid=sa;pwd=123456;database=StoreSystem;");
                con.Open();
                if (con.State == ConnectionState.Open)
                {//打开数据库
                    string sql = string.Format("select * from UserInfo where userPassword = '{0}'", txtUserPwd.Text.Trim());
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        MessageBox.Show("登录成功", "系统提示", MessageBoxButtons.OK);
                        name = txtUserName.Text.Trim();
                        MainFrame mf = new MainFrame();
                        mf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("密码错误", "系统提示", MessageBoxButtons.OK);
                        return;
                    }
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
        }//用户密码
        private void button1_Click(object sender, EventArgs e)
        {
            if (panduan())
            {
                if (textBox1.Text.Trim() == label3.Text || textBox1.Text.Trim().ToLower() == label3.Text.ToLower())//验证码比较
                {
                    userPwd();//验证密码
                }
                else
                {
                    MessageBox.Show("验证码错误", "系统提示", MessageBoxButtons.OK);
                    textBox1.Text = string.Empty;
                    yanzhengma();
                }
            }
        }
        Random rd = new Random();
        string no = null;
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
            label3.Text = no;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定取消登录吗?", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }

        private void txtUserPwd_MouseDown(object sender, MouseEventArgs e)
        {
            userName();//验证用户名
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {   
            yanzhengma();

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定取消登录吗?", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
        public static int A;
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "AddUserForm")
                {//商品结算
                    item.BringToFront();
                    return;
                }
            }
            AddUserForm add = new AddUserForm();
            A = 0;
            add.Show();
        }
    }
}
