using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace _01_作业
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=Test_01_sj");
            sqlConnection.Open();
            string sql = string.Format("select * from mingxing");
            SqlCommand sqlCommand = new SqlCommand(sql,sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                ListViewItem listViewItem = new ListViewItem(sqlDataReader[0].ToString());
                listViewItem.SubItems.Add(sqlDataReader[1].ToString());
                listViewItem.SubItems.Add(sqlDataReader[2].ToString());              
                listView1.Items.Add(listViewItem);
            }
            sqlConnection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    }
}
