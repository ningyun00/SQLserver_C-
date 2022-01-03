using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//1.引入数据库

namespace _01_作业1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=XYQ");//2.3.创建数据库对象，连接字符串
            sqlConnection.Open();//4.打开数据库
            string sql = string.Format("insert into XYQ values('{0}', '{1}', GETDATE()) ", textBox1.Text.Trim(), textBox2.Text.Trim());//5.添加值
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);//6.创建命令对象
            if (sqlCommand.ExecuteNonQuery() > 0)//7.受影响行数
            {
                MessageBox.Show("许愿成功", "提示");
            }
            else
            {
                MessageBox.Show("许愿失败", "提示");
            }
            sqlConnection.Close();//8.关闭数据库
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=XYQ");//2.3.创建数据库对象，连接字符串
            sqlConnection.Open();//4.打开数据库
            SqlCommand sqlCommand = new SqlCommand(string.Format("select count(*) from xyq"), sqlConnection);//5.6.内容，创建命令对象
            linkLabel1.Text = ((int)sqlCommand.ExecuteScalar()).ToString();//7.执行命令对象 object类型
            sqlConnection.Close();//8.关闭数据库
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=XYQ");//连接
            sqlConnection.Open();//打开
            SqlCommand sqlCommand = new SqlCommand(string.Format("select XYText from XYQ order by NEWID()"), sqlConnection);//内容，命令对象
            textBox3.Text = sqlCommand.ExecuteScalar().ToString();//执行对象
            sqlConnection.Close();//关数据库
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != string.Empty)
            {
                SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=XYQ");//连接
                sqlConnection.Open();//打开
                SqlCommand sqlCommand = new SqlCommand(string.Format("select * from XYQ where ID = {0}", textBox4.Text.Trim()), sqlConnection);//内容,命令对象
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();//执行命令对象SqlDataReader阅读器对象
                if (sqlDataReader.Read())
                {
                    textBox5.Text = sqlDataReader[1].ToString();
                    textBox6.Text = sqlDataReader[3].ToString();
                    textBox7.Text = sqlDataReader[2].ToString();
                }
                else
                {
                    MessageBox.Show("查询超出范围无此{0}ID" + textBox4.Text, "提示");
                }
                sqlConnection.Close();//关闭数据库
            }
            else
            {
                MessageBox.Show("请输入ID", "提示");
            }
        }
    }
}
