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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }
        private bool addweikong()
        {//添加用户，密码为空
            if (txtTelphone.Text == string.Empty)
            {
                MessageBox.Show("请填入用户电话", "系统提示", MessageBoxButtons.OK);
                return false;
            }
            if (txtRemark.Text == string.Empty)
            {
                MessageBox.Show("请填入备注", "系统提示", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }//添加用户为空
        private void addUser()
        {//添加用户方法
            SqlConnection con = null;
            if (addweikong())
            {
                try
                {
                    con = new SqlConnection("server=.;uid=sa;pwd=123456;database=StoreSystem");
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {//打开数据库
                        string sql = string.Format("  insert into UserInfo values('{0}', '{1}', 0, '{2}', '{3}')", txtUserName.Text.Trim(), txtUserPwd.Text.Trim(), txtTelphone.Text.Trim(), txtRemark.Text.Trim());
                        SqlCommand cmd = new SqlCommand(sql, con);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("添加用户成功", "系统提示", MessageBoxButtons.OK);
                            txtUserName.Text = string.Empty;
                            txtUserPwd.Text = string.Empty;
                            txtTelphone.Text = string.Empty;
                            txtRemark.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("添加用户失败", "系统提示", MessageBoxButtons.OK);
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
            }
        }//添加用户
        private void button1_Click(object sender, EventArgs e)
        {
            if (nun_null())
            {
                if (LoginForm.A == 0)
                {
                    addUser();
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Hide();
                }
                else if (LoginForm.A == 1)
                {
                    addUser();
                }
            }
        }

        private bool nun_null()
        {
            if (txtUserName.Text == string.Empty)
            {
                MessageBox.Show("用户名不能为空", "系统提示");
                return false;
            }
            if (txtUserPwd.Text == string.Empty)
            {
                MessageBox.Show("密码不能为空", "系统提示");
                return false;
            }
            if (txtTelphone.Text == string.Empty)
            {
                MessageBox.Show("电话不能为空", "系统提示");
                return false;
            }

            return true;
        }
    }
}
