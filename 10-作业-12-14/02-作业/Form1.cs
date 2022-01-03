using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _02_作业
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
            string sex = radioButton1.Text;
            if (radioButton1.Checked==true)
            {
                sex = "男";
            }
            else if (radioButton2.Checked==true)
            {
                sex = "女";
            }
            string sql = string.Format("insert  into  teacher values('{0}', '{1}', {2},'{3}')",textBox2.Text.Trim(),sex,textBox3.Text.Trim(),string.Empty);
            SqlCommand sqlCommand = new SqlCommand(sql,sqlConnection);
            int CENQ = sqlCommand.ExecuteNonQuery();
            if (CENQ>0)
            {
                MessageBox.Show("添加成功","提示");
            }
            else
            {
                MessageBox.Show("添加失败","提示");
            }
            sqlConnection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=AAA");
            sqlConnection.Open();
            string sql = string.Format("select * from teacher");
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                ListViewItem listViewItem = new ListViewItem(sqlDataReader[0].ToString());
                listViewItem.SubItems.Add(sqlDataReader[1].ToString());
                listViewItem.SubItems.Add(sqlDataReader[2].ToString());
                listViewItem.SubItems.Add(sqlDataReader[3].ToString());
                listViewItem.SubItems.Add(sqlDataReader[4].ToString());
                listView1.Items.Add(listViewItem);
            }
            sqlConnection.Close();
        }
    }
}
