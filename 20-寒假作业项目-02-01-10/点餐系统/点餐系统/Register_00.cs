using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 点餐系统
{
    public partial class Register_00 : Form
    {
        public Register_00()
        {
            InitializeComponent();
        }
        NET net = new NET();
        string sql;
        mainInterface_01 mainInterface = new mainInterface_01();
        public static string start;
        public static string name;
        private void button2_Click(object sender, EventArgs e)
        {
            if (not_null())
            {
                if (radioButton1.Checked == true)
                {
                    sql = string.Format("select * from User_06 where UserName ='{0}' and UserPwd = '{1}'", textBox1.Text.Trim(), textBox2.Text.Trim());
                    IDataReader idr = net.Sdr(sql);
                    if (idr.Read())
                    {
                        start = "普通员";
                        name = idr["UserName"].ToString();
                        mainInterface.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("登陆失败", "系统提示");
                    }
                }
                else if (radioButton2.Checked == true)
                {
                    sql = string.Format("select * from Adm_07 where AdmName = '{0}' and AdmPwd = '{1}'", textBox1.Text.Trim(), textBox2.Text.Trim());
                    IDataReader idr = net.Sdr(sql);
                    if (idr.Read())
                    {
                        start = "管理员";
                        name = idr["AdmName"].ToString();
                        mainInterface.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("登陆失败", "系统提示");
                    }
                }
            }
        }

        private bool not_null()
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
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start = "普通员";
            Login_07 login = new Login_07();
            login.ShowDialog();
            this.Hide();
        }

        private void Register_00_Load(object sender, EventArgs e)
        {

        }
    }
}
