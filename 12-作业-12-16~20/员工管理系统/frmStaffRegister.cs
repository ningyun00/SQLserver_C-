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
public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {//登录
            SqlConnection sqlConnection = null;
            //登录用户名都为空
            if (textBox1.Text.Trim() == string.Empty && textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("用户名和密码不能为空", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }//用户名为空
            else if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("用户名不能为空", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }//密码为空
            else if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("密码不能为空", "系统提示");
            }
            else
            {//创建连接对象，连接字符串，连接数据库StaffManage
                try
                {
                    sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=StaffManage");
                    //打开数据库
                    sqlConnection.Open();
                    //打开才执行
                    if (sqlConnection.State == ConnectionState.Open)
                    {//查询输入的密码和用户名是否相同
                        SqlCommand sqlCommand = new SqlCommand(string.Format("select * from T_User where UserName= '{0}' and PassWord ='{1}'", textBox1.Text.Trim(), textBox2.Text.Trim()), sqlConnection);
                        //单行查询 阅读器
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                        //循环阅读器
                        if (sqlDataReader.Read())
                        {
                            MessageBox.Show("登陆成功", "系统提示");
                            //创建新窗体的对象
                            frmStaffHomepage FSH = new frmStaffHomepage();
                            //跳转
                            FSH.Show();
                            //隐藏
                            this.Hide();
                            user.Name =sqlDataReader["UserName"].ToString();
                            user.Id = int.Parse(sqlDataReader["ID"].ToString());
                        }
                        
                        else
                        {
                            MessageBox.Show("用户名或密码错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else//数据库未打开
                    {
                        MessageBox.Show("数据库未打开", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    if (sqlConnection.State == ConnectionState.Open)
                    {//当数据库打开关闭
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//取消 结束进程
            Application.ExitThread();
        }
    }
}
