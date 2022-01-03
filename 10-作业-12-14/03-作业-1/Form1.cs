using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _03_作业_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=AAA");
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("select * from Book where bId = {0}", textBox1.Text.Trim()), sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    textBox2.Text = sqlDataReader[1].ToString();
                    textBox3.Text = sqlDataReader[3].ToString();
                    textBox4.Text = sqlDataReader[4].ToString();
                    textBox5.Text = sqlDataReader[2].ToString();
                }
                else
                {
                    MessageBox.Show("查询超出范围","提示");
                }
                sqlConnection.Close();
            }
            else
            {
                MessageBox.Show("请输入书籍编号", "提示");
            }
        }
    }
}
