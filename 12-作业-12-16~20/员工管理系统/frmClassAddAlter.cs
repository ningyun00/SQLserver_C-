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
    public partial class frmClassAddAlter : Form
    {
        public frmClassAddAlter()
        {
            InitializeComponent();
        }

        int shuyuzhi;//传递
        private void button1_Click(object sender, EventArgs e)
        {
            frmStaffHomepage homepage = new frmStaffHomepage();
            shuyuzhi = homepage.zhi;//赋值
            if (A == 0)
            {//zhi==1==添加
                tianjia();

            }
            if (A > 0)
            {//修改、
                xuigai();
            }
        }
        public int A;
        private void xuigai()
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection("server=.;uid=sa;pwd=123456;database=StaffManage");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {//修改
                    SqlCommand command = new SqlCommand(string.Format("update T_Class set Cname = '{0}',Cremarks='{1}' where CID = '{2}'", textBox1.Text.Trim(), textBox2.Text.Trim(), A), connection);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("修改成功", "系统提示", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("修改失败", "系统提示", MessageBoxButtons.OK);
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
            {
                if (connection.State == ConnectionState.Open)
                {//当数据库打开关闭
                    connection.Close();
                }
            }
        }

        private void tianjia()
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection("server=.;uid=sa;pwd=123456;database=StaffManage");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    SqlCommand command = new SqlCommand(string.Format("insert  into T_Class values('{0}','{1}')", textBox1.Text.Trim(), textBox2.Text.Trim()), connection);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("添加成功", "系统提示", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("添加成功", "系统提示", MessageBoxButtons.OK);
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
            {
                if (connection.State == ConnectionState.Open)
                {//当数据库打开关闭
                    connection.Close();
                }
            }
        }

        private void frmClassAddAlter_Load(object sender, EventArgs e)
        {
            if (A == 0)
            {
                button1.Text = "添加";
            }
            else if (A > 0)
            {
                button1.Text = "修改";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }
    }
}
