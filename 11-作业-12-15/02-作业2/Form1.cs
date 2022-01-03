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
            SqlConnection sqlConnection = new SqlConnection("server = .;uid=sa;pwd=123456;database=MutilTableSelect");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(string.Format(@"insert  into StudentInf values('{0}','{1}',{2},'{3}',{4})",
            textBox1.Text.Trim(),
            radioButton1.Checked == true ? "男" : "女",
            int.Parse(textBox2.Text.Trim()),
            comboBox1.SelectedItem.ToString(),
            comboBox2.SelectedValue.ToString()), sqlConnection);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("添加成功", "提示");
            }
            else
            {
                MessageBox.Show("添加失败", "提示");
            }
            sqlConnection.Close();
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            string str = "server=.;uid=sa;pwd=123456;database=MutilTableSelect";
            SqlConnection sqlconn = new SqlConnection(str);
            sqlconn.Open();
            string sql = string.Format("select * from Dorm");
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlconn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.ValueMember = "dormId";//隐藏--只拿隐藏
            comboBox2.DisplayMember = "dormName";//显示
            sqlconn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
