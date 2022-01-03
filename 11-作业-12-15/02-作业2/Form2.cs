using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _02_作业2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=MutilTableSelect");
            sqlConnection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(string.Format("select stuId, stuName, stuSex, dormPos from StudentInf inner join Dorm on StudentInf.stuDormId = Dorm.dormId where stuName like '%{0}%'", textBox1.Text.Trim()), sqlConnection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            sqlConnection.Close();
        }
    }
}
