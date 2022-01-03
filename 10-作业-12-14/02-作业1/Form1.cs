using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//引入数据库

namespace _02_作业1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=AAA");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(String.Format("select * from teacher where ID = {0}", textBox1.Text.Trim()), sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                textBox2.Text = sqlDataReader[1].ToString();
                textBox3.Text = sqlDataReader[3].ToString();
                textBox4.Text = sqlDataReader[4].ToString();
                if (sqlDataReader[2].ToString() == "男")
                {
                    radioButton1.Checked = true;
                }
                else if (sqlDataReader[2].ToString() == "女")
                {
                    radioButton2.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("查询超出范围", "提示");
            }
            sqlConnection.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=AAA");
            sqlConnection.Open();
            string sex = radioButton1.Text;
            if (radioButton1.Checked==true)
            {
                sex = "男";
            }
            else if (radioButton2.Checked==true)
            {
                sex = "女";
            }
            SqlCommand sqlCommand = new SqlCommand(String.Format("update teacher set name ='{0}', sex = '{1}', age = {2}, address = '{3}'  where id = {4}",textBox2.Text.Trim(),sex,textBox3.Text.Trim(),textBox4.Text.Trim(), textBox1.Text.Trim()), sqlConnection);
            if (sqlCommand.ExecuteNonQuery()>0)
            {
                MessageBox.Show("修改成功","提示");
            }
            else
            {
                MessageBox.Show("修改失败","提示");
            }
            sqlConnection.Close();
        }
    }
}
