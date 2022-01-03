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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=Test_01_sj");
            sqlConnection.Open();
            string sql = string.Format("insert into mingxing values('{0}', '{1}', {2}); ", textBox1.Text.Trim(), textBox2.Text.Trim(), int.Parse(textBox3.Text.Trim()));
            SqlCommand sqlCommand = new SqlCommand(sql,sqlConnection) ;
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
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
