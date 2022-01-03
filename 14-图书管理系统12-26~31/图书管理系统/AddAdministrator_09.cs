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
    public partial class AddAdministrator_09 : Form
    {
        public AddAdministrator_09()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.;uid=sa;pwd=123456;database=Book");

        Random rd = new Random();

        string no = null;

        private void AddAdministrator_09_Load(object sender, EventArgs e)
        {
            yanzhengma();//12位验证码
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            yanzhengguanliyuanyonghu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nun_null())
            {
                if (textBox2.Text.Trim() == textBox3.Text.Trim())
                {
                    tianjia();
                    click();
                }
                else
                {
                    MessageBox.Show("新旧密码不同", "系统提示");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定取消添加吗?", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Close();
            }
        }
        private void click()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }//清空

        private void tianjia()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("insert into[Administrator] values('{0}', '{1}', '{2}')", textBox1.Text.Trim(), textBox3.Text.Trim(), no);
                    SqlCommand com = new SqlCommand(sql, con);
                    if (com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("添加成功", "系统提示");
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

        private void yanzhengguanliyuanyonghu()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from [Administrator] where Aname = '{0}'", textBox1.Text.Trim());
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader sdr = com.ExecuteReader();
                    if (sdr.Read())
                    {//找到用户
                        MessageBox.Show("已有（" + textBox1.Text.Trim() + "）管理员用户", "系统提示", MessageBoxButtons.OK);
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
        }//是否出现重复用户名

        private void yanzhengma()
        {
            char no1 = (char)rd.Next(65, 91);
            char no2 = (char)rd.Next(65, 91);
            char no3 = (char)rd.Next(65, 91);
            char no4 = (char)rd.Next(65, 91);
            char no5 = (char)rd.Next(65, 91);
            char no6 = (char)rd.Next(65, 91);
            char no7 = (char)rd.Next(65, 91);
            char no8 = (char)rd.Next(65, 91);
            char no9 = (char)rd.Next(65, 91);
            char no10 = (char)rd.Next(65, 91);
            char no11 = (char)rd.Next(65, 91);
            char no12 = (char)rd.Next(65, 91);
            no = no1.ToString();
            no = no + no2.ToString();//拼接
            no = no + no3.ToString();
            no = no + no4.ToString();
            no = no + no5.ToString();
            no = no + no6.ToString();
            no = no + no7.ToString();
            no = no + no8.ToString();
            no = no + no9.ToString();
            no = no + no10.ToString();
            no = no + no11.ToString();
            no = no + no12.ToString();
            label5.Text = no;
        }//12位验证码

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
            return true;
        }//非空验证
    }
}
