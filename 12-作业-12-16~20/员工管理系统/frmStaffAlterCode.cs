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
    public partial class frmStaffAlterCode : Form
    {
        public frmStaffAlterCode()
        {
            InitializeComponent();
        }
        string pwd = null;
        private bool a = false;//声明一个布尔值关闭
        private void button1_Click(object sender, EventArgs e)
        {//修改密码
            SqlConnection connection = null;
            if (textBox1.Text.Trim() != string.Empty)
            {//原密码不为空执行
                try
                {
                    connection = new SqlConnection("server=.;uid=sa;pwd=123456;database=StaffManage");
                    //打开数据库
                    connection.Open();
                    //判断数据库是否打开
                    if (connection.State == ConnectionState.Open)
                    {//查询登录名的id和用户名
                        SqlCommand command = new SqlCommand(string.Format("select * from T_User where UserName= '{0}' and ID = {1}", user.Name, user.Id), connection);
                        //创建阅读器对象
                        SqlDataReader dataReader = command.ExecuteReader();
                        //执行阅读器
                        if (dataReader.Read())
                        {//存入密码
                            pwd = dataReader["PassWord"].ToString();
                        }
                        if (pwd != textBox1.Text.Trim())
                        {//数据库密码与旧密码不相同
                            MessageBox.Show("原密码错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //返回
                            return;
                        }
                        else
                        {
                            if (textBox2.Text.Trim() == string.Empty)
                            {//新密码为空
                                MessageBox.Show("请输入新密码", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else
                            {//第二次新密码为空
                                if (textBox3.Text.Trim() == string.Empty)
                                {
                                    MessageBox.Show("请再次输入新密码", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                else
                                {//两次密码不相同
                                    if (textBox2.Text.Trim() != textBox3.Text.Trim())
                                    {
                                        MessageBox.Show("两次密码不相同相同", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }
                                    else
                                    {//两次密码与旧密码相同
                                        if (textBox1.Text.Trim() == textBox2.Text.Trim() && textBox1.Text.Trim() == textBox3.Text.Trim())
                                        {
                                            MessageBox.Show("新旧密码相同", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            return;
                                        }
                                        else
                                        {//返回执行
                                            a = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("数据库未打开", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {//一定执行
                    if (connection.State == ConnectionState.Open)
                    {//当数据库打开关闭
                        connection.Close();
                    }
                }
                if (a)
                {
                    try
                    {
                        connection = new SqlConnection("server=.;uid=sa;pwd=123456;database=StaffManage");
                        //打开数据库
                        connection.Open();
                        //判断是否打开数据库
                        if (connection.State == ConnectionState.Open)
                        {//拿取登录名的id进行改密码
                            SqlCommand command = new SqlCommand(string.Format("update T_User set PassWord='{0}'where ID={1}", textBox3.Text.Trim(), user.Id), connection);
                            //判断是否成功
                            if (command.ExecuteNonQuery() > 0)
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
                            MessageBox.Show("数据库未打开", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {//一定执行
                        if (connection.State == ConnectionState.Open)
                        {//当数据库打开关闭
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请输入原密码", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
