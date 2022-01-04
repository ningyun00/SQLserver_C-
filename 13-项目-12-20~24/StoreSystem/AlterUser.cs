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
    public partial class AlterUser : Form
    {
        public AlterUser()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == pwd)
            {
                SqlConnection sqlconn = null;
                try
                {
                    sqlconn = new SqlConnection("server= .;uid= sa;pwd= 123456;database= StoreSystem ");
                    sqlconn.Open();
                    string sql = string.Format("update Userinfo set  username = '{0}',userpassword='{1}',usertelphone='{2}',userremark='{3}' where userid = {4}", textBox1.Text, textBox5.Text, textBox3.Text, textBox4.Text, UserInfoManage.A);
                    SqlCommand com = new SqlCommand(sql, sqlconn);
                    if (com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("修改成功", "系统提示");
                        foreach (Form item in MdiChildren)
                        {
                            if (item.GetType().Name == "UserInfoManage")
                            {//商品类型管理
                                item.BringToFront();
                                return;
                            }
                        }
                        UserInfoManage ufm = new UserInfoManage();
                        ufm.MdiParent = this.MdiParent;
                        ufm.Show();
                    }
                    else
                    {
                        MessageBox.Show("修改失败", "系统提示");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "系统错误提示");
                }
                finally
                {
                    if (sqlconn.State == ConnectionState.Open)
                    {
                        sqlconn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("两次输入密码不同", "系统提示");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            Close();
        }
        public string pwd;
        private void AlterUser_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconn = null;
            try
            {
                sqlconn = new SqlConnection("server= .;uid= sa;pwd= 123456;database= StoreSystem ");
                sqlconn.Open();
                string sql = string.Format("select * from UserInfo where Userid = {0}", UserInfoManage.A);
                SqlCommand com = new SqlCommand(sql, sqlconn);
                SqlDataReader sdr = com.ExecuteReader();
                if (sdr.Read())
                {
                    textBox1.Text = sdr["username"].ToString();
                    pwd = sdr["userpassword"].ToString();
                    textBox3.Text = sdr["usertelphone"].ToString();
                    textBox4.Text = sdr["userremark"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误提示");
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }
        }
    }
}
