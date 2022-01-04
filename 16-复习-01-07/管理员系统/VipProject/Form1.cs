using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//引入命名空间

namespace VipProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string name;//传值

        SqlConnection con = new SqlConnection("server=.;uid=sa;pwd=123456;database =MembersInfo_DB");
        //连接数据库
        private void button1_Click(object sender, EventArgs e)
        {//登录
            try
            {//异常处理
                if (nun_null())
                {//为空判断
                    con.Open();
                    //打开数据库
                    if (con.State == ConnectionState.Open)
                    {//打开才执行
                        string sql = string.Format("select * from MembersInfo where M_Name = '{0}' and M_Pwd = '{1}'", textBox1.Text.Trim(), textBox2.Text.Trim());
                        //执行SQL语句
                        SqlCommand com = new SqlCommand(sql, con);
                        //执行命令
                        SqlDataReader sdr = com.ExecuteReader();
                        //阅读器对象
                        if (sdr.Read())
                        {//执行阅读器
                            name = sdr["M_Name"].ToString();
                            Form2 from = new Form2();
                            from.Show();
                            this.Hide();
                        }
                        else
                        {//未找到
                            MessageBox.Show("用户名或密码错误", "系统提示");
                        }
                    }
                    else
                    {//关闭
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {//提示出异常处理
                MessageBox.Show(ex.Message, "来自系统提示");
            }
            finally
            {//执行关闭数据库
                con.Close();
            }
        }

        private bool nun_null()
        {//为空
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
        }

        private void button2_Click(object sender, EventArgs e)
        {//清空
            DialogResult dr = MessageBox.Show("是否清空", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == dr)
            {//清空判断
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
            else
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//退出
            DialogResult dr = MessageBox.Show("是否取消", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == dr)
            {//退出判断
                Application.Exit();
                //退出
            }
            else
            {//取消
                return;
            }
        }
    }
}
