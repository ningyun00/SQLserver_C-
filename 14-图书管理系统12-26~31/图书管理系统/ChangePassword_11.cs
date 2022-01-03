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
    public partial class ChangePassword_11 : Form
    {
        public ChangePassword_11()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.;uid=sa;pwd=123456;database=Book");

        private void ChangePassword_11_Load(object sender, EventArgs e)
        {
            label2.Text = Data.state;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定取消修改吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Close();
            }
        }

        string pwd = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (nun_null())
            {
                if (MessageBox.Show("即将修改密码", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    if (Data.state == "管理员")
                    {
                        yonghumingguanliyuan();
                        if (Data.name != textBox1.Text)
                        {
                            MessageBox.Show("用户名不匹配", "系统提示");
                            return;
                        }
                        if (textBox2.Text != pwd)
                        {
                            MessageBox.Show("原密码错误", "系统提示");
                            return;
                        }
                        if (textBox2.Text == textBox3.Text || textBox2.Text == textBox4.Text)
                        {
                            MessageBox.Show("新旧密码相同", "系统提示");
                            return;
                        }
                        if (textBox3.Text != textBox4.Text)
                        {
                            MessageBox.Show("两次输入密码不同", "系统提示");
                            return;
                        }
                        else
                        {
                            xuigaiguanliyuan();
                            if (MessageBox.Show("即将退出程序", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                            {
                                MessageBox.Show("将在5秒后退出", "系统提示");
                                System.Threading.Thread.Sleep(5000);
                                Application.ExitThread();
                                Application.Restart();
                            }
                            else
                            {
                                MessageBox.Show("将在5秒后退出", "系统提示");
                                System.Threading.Thread.Sleep(5000);
                                Application.ExitThread();
                                Application.Restart();
                            }
                        }
                    }
                    else
                    {
                        yonghumingputo();
                        if (Data.name != textBox1.Text)
                        {
                            MessageBox.Show("用户名不匹配", "系统提示");
                            return;
                        }
                        if (textBox2.Text != pwd)
                        {
                            MessageBox.Show("原密码错误", "系统提示");
                            return;
                        }
                        if (textBox2.Text == textBox3.Text || textBox2.Text == textBox4.Text)
                        {
                            MessageBox.Show("新旧密码相同", "系统提示");
                            return;
                        }
                        if (textBox3.Text != textBox4.Text)
                        {
                            MessageBox.Show("两次输入密码不同", "系统提示");
                            return;
                        }
                        else
                        {
                            xuigaiputo();
                            if (MessageBox.Show("即将退出程序", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                            {
                                MessageBox.Show("将在5秒后退出", "系统提示");
                                System.Threading.Thread.Sleep(5000);
                                Application.ExitThread();
                                Application.Restart();
                            }
                            else
                            {
                                MessageBox.Show("将在5秒后退出", "系统提示");
                                System.Threading.Thread.Sleep(5000);
                                Application.ExitThread();
                                Application.Restart();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("修改已取消", "系统提示");
                }
            }
        }

        private void yonghumingguanliyuan()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from [Administrator] where [Aname] = '{0}'", Data.name);
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader sdr = com.ExecuteReader();
                    if (sdr.Read())
                    {
                        pwd = sdr["Apwd"].ToString();
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

        private void xuigaiguanliyuan()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("update [Administrator] set Apwd = '{0}' where Aname = '{1}' and Apwd = '{2}'", textBox4.Text.Trim(), Data.name, textBox2.Text.Trim());
                    SqlCommand com = new SqlCommand(sql, con);
                    if (com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("修改成功", "系统提示");
                    }
                    else
                    {
                        MessageBox.Show("修改失败", "系统提示");
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

        private void xuigaiputo()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("update[User] set Upwd = '{0}' where Uname = '{1}' and Upwd = '{2}'", textBox4.Text.Trim(), Data.name, textBox2.Text.Trim());
                    SqlCommand com = new SqlCommand(sql, con);
                    if (com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("修改成功", "系统提示");
                    }
                    else
                    {
                        MessageBox.Show("修改失败", "系统提示");
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
        }//修改密码普通用户

        private bool nun_null()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("验证用户名不能为空", "系统提示");
                return false;
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("原密码不能为空", "系统提示");
                return false;
            }
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("请输入密码", "系统提示");
                return false;
            }
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("请再次密码", "系统提示");
                return false;
            }
            return true;
        }//非空验证

        private void yonghumingputo()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from [User] where [Uname] = '{0}'", Data.name);
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader sdr = com.ExecuteReader();
                    if (sdr.Read())
                    {
                        pwd = sdr["Upwd"].ToString();
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
        }//普通用户密码验证
    }
}
