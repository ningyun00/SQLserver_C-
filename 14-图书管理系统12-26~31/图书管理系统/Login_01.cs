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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.;uid=sa;pwd=123456;database=Book");

        public static int A;

        private bool non_null()
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入用户名", "系统提示");
                return false;
            }
            if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入密码", "系统提示");
                return false;
            }
            return true;
        }//非空验证

        private void button1_Click(object sender, EventArgs e)
        {
            if (non_null())
            {//非空验证
                password();
                if (radioButton3.Checked == true)
                {
                    miyaodenglu();
                }
            }
        }//登录

        private void miyaodenglu()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from [Administrator] where Akeys = '{0}'", textBox2.Text.Trim());
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader sdr = com.ExecuteReader();
                    if (sdr.Read())
                    {//密码正确
                        MessageBox.Show("用户（" + textBox1.Text.Trim() + "）登陆成功", "系统提示", MessageBoxButtons.OK);
                        //跳转
                        Data data = new Data();
                        Data.name = textBox1.Text.Trim();
                        Data.state = "管理员";
                        Homepage_02 zhuye = new Homepage_02();
                        zhuye.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("用户（" + textBox1.Text.Trim() + "）备用密码登陆失败，密码错误", "系统提示", MessageBoxButtons.OK);
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定取消登录吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.ExitThread();//退出系统
            }
        }//取消

        private void password()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    if (radioButton1.Checked == true)
                    {//普通用户密码
                        string sql = string.Format("select * from [User] where [Upwd] = '{0}'", textBox2.Text.Trim());
                        SqlCommand com = new SqlCommand(sql, con);
                        SqlDataReader sdr = com.ExecuteReader();
                        if (sdr.Read())
                        {//密码正确
                            if (textBox1.Text == sdr["Uname"].ToString())
                            {
                                MessageBox.Show("用户（" + textBox1.Text.Trim() + "）登陆成功", "系统提示", MessageBoxButtons.OK);
                                //跳转
                                Data data = new Data();
                                Data.name = textBox1.Text.Trim();
                                Data.state = "普通用户";
                                Homepage_02 zhuye = new Homepage_02();
                                zhuye.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("用户（" + textBox1.Text.Trim() + "）登陆失败，密码错误", "系统提示", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("用户（" + textBox1.Text.Trim() + "）登陆失败，密码错误", "系统提示", MessageBoxButtons.OK);
                        }
                    }
                    if (radioButton2.Checked == true)
                    {//管理员用户密码
                        string sql = string.Format("select [AID], [Aname], [Apwd] from [Administrator] where [Apwd] = '{0}'", textBox2.Text.Trim());
                        SqlCommand com = new SqlCommand(sql, con);
                        SqlDataReader sdr = com.ExecuteReader();
                        if (sdr.Read())
                        {//密码正确
                            if (textBox1.Text == sdr["Aname"].ToString())
                            {
                                MessageBox.Show("管理员（" + textBox1.Text.Trim() + "）登陆成功", "系统提示", MessageBoxButtons.OK);
                                //跳转
                                Data data = new Data();
                                Data.name = textBox1.Text.Trim();
                                Data.state = "管理员";
                                Homepage_02 zhuye = new Homepage_02();
                                zhuye.Show();
                                this.Hide();
                                if (com.ExecuteNonQuery()>0)
                                {

                                }
                            }
                            else
                            {
                                MessageBox.Show("管理员（" + textBox1.Text.Trim() + "）登陆失败，密码错误", "系统提示", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("管理员（" + textBox1.Text.Trim() + "）登陆失败，密码错误", "系统提示", MessageBoxButtons.OK);
                        }
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
        }

        private void find()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    if (radioButton1.Checked == true)
                    {//普通用户
                        string sql = string.Format("select [Uid],[Uname],[Upwd] from [User] where [Uname] = '{0}'", textBox1.Text.Trim());
                        SqlCommand com = new SqlCommand(sql, con);
                        SqlDataReader sdr = com.ExecuteReader();
                        if (sdr.Read())
                        {//找到用户                             
                        }
                        else
                        {
                            MessageBox.Show("没有（" + textBox1.Text.Trim() + "）普通用户", "系统提示", MessageBoxButtons.OK);
                        }
                    }
                    if (radioButton2.Checked == true)
                    {//管理员
                        string sql = string.Format("select [AID], [Aname], [Apwd] from [Administrator] where [Aname] = '{0}'", textBox1.Text.Trim());
                        SqlCommand com = new SqlCommand(sql, con);
                        SqlDataReader sdr = com.ExecuteReader();
                        if (sdr.Read())
                        {//找到用户                        
                        }
                        else
                        {
                            MessageBox.Show("没有（" + textBox1.Text.Trim() + "）管理员用户", "系统提示", MessageBoxButtons.OK);
                        }
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
        }//查找用户
        /// <summary>
        /// 普通用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_Click(object sender, EventArgs e)
        {
            find();
        }
        /// <summary>
        /// 管理员用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_Click(object sender, EventArgs e)
        {
            find();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //RegisteredUsers_11 registeredUsers = new RegisteredUsers_11();
            //registeredUsers.Show();
            //this.Hide();
            AddUser_08 addUser = new AddUser_08();
            AddUser_08.num = 0;
            addUser.Show();
            this.Hide();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定退出程序吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.ExitThread();//退出系统
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            A = 1;
        }
    }
}
