using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//1.引入数据源

namespace _01_作业1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 方法
        private void selectAll()
        {
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=晚上大课");
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format("select book_id,book_name,book_author,book_chubanshe,book_price from book;"), sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
            sqlConnection.Close();
        }
        #endregion
        /// <summary>
        /// 显示所有图书至ListView内
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=晚上大课");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(string.Format("select book_id,book_name,book_author,book_chubanshe,book_price from book"), sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();//阅读器对象
            while (sqlDataReader.Read())//循环阅读器对象
            {
                ListViewItem listViewItem = new ListViewItem(sqlDataReader[0].ToString());//创建行
                listViewItem.SubItems.Add(sqlDataReader[1].ToString());
                listViewItem.SubItems.Add(sqlDataReader[2].ToString());
                listViewItem.SubItems.Add(sqlDataReader[3].ToString());
                listViewItem.SubItems.Add(sqlDataReader[4].ToString());//创建列
                listView1.Items.Add(listViewItem);//使用
            }
            sqlConnection.Close();
        }
        /// <summary>
        /// 显示所有图书至DateGridView内
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=晚上大课");
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format("select book_id,book_name,book_author,book_chubanshe,book_price from book;"), sqlConnection);
            //黑道--创建数据适配器对象:
            DataSet dataSet = new DataSet();
            //创建数据
            sqlDataAdapter.Fill(dataSet);
            //集填充到数据集
            dataGridView1.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
        }
        /// <summary>
        /// 删除DateGridView中选中的图书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=晚上大课");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(string.Format(@"delete from book where book_id = {0}", dataGridView1.SelectedRows[0].Cells["Column1"].Value.ToString()), sqlConnection);//
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("删除成功", "提示");
                selectAll();
            }
            else
            {

                MessageBox.Show("删除失败", "提示");
            }
            sqlConnection.Close();
        }
        /// <summary>
        /// 按书名查询显示至DateGridView内
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server=.;uid=sa;pwd=123456;database=晚上大课");
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format(@"select book_id,book_name,book_author,book_chubanshe,book_price from book where 1=1 and book_name like '%{0}%'", textBox1.Text.Trim()), sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
        }
    }
}
