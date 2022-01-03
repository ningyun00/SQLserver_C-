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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=EmpManager");
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format("select * from EmpInfo where EmpName like '%{0}%'", textBox1.Text.Trim()), sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server = .;uid=sa;pwd=123456;database=EmpManager");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(string.Format(@" update EmpInfo set EmpName='{0}',EmpDep='{1}',EmpBirthday='{2}',EmpMobile='{3}'  where  EmpID= '{4}'", textBox2.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim(), textBox5.Text.Trim(),label7.Text.Trim()), sqlConnection);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("修改成功", "提示");
                tabControl1.SelectTab(0);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format("select * from EmpInfo where EmpName like '%{0}%'", textBox2.Text.Trim()), sqlConnection);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            else
            {
                MessageBox.Show("修改失败", "提示");
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tabControl1.SelectTab(1);//跳转页面
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=EmpManager");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(string.Format("select * from EmpInfo where EmpName like '%{0}%'", textBox1.Text.Trim()), sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            dataGridView1.CurrentCell.Value.ToString();
            label7.Text = dataGridView1.SelectedRows[0]/*列*/.Cells[0].Value.ToString();//获取单行数据
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            sqlConnection.Close();
        }
    }
}
