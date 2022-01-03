using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _03_作业3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();
        private string name;
        private string pwd;
        private void selectAll()
        {
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=EmpManager");
            sqlConnection.Open();
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("请输入用户名或密码", "提示");
                sqlConnection.Close();
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand(string.Format("select EmpName,EmpPwd from EmpInfo"), sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    name = sqlDataReader["EmpName"].ToString();
                    pwd = sqlDataReader["EmpPwd"].ToString();
                    if (textBox1.Text == name && textBox2.Text == pwd)
                    {
                        MessageBox.Show("欢迎" + name + "登陆成功", "提示");
                        this.Hide();
                        form2.Show();
                        break;
                    }
                    else
                    {
                        continue;//错误
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            selectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Application.Exit();
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                selectAll();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
