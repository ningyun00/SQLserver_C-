using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StoreSystem
{
    public partial class UserInfoManage : Form
    {
        public UserInfoManage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//查询所有
            shuaxin();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {//删除
            if (MessageBox.Show("确定删除吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                shanchu();
            }
            else
            {
                return;
            }
        }
        private void shuaxin()
        {
            SqlConnection sqlconn = null;
            try
            {
                sqlconn = new SqlConnection("server= .;uid= sa;pwd= 123456;database= StoreSystem ");
                sqlconn.Open();
                string sql = string.Format("select * from UserInfo");
                SqlDataAdapter sda = new SqlDataAdapter(sql, sqlconn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误提示");
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }

            }
        }
        private void shanchu()
        {
            SqlConnection sqlconn = new SqlConnection("server= .;uid= sa;pwd= 123456;database= StoreSystem");
            sqlconn.Open();
            string sql = string.Format("delete from UserInfo where userID='{0}'", dataGridView1.SelectedRows[0].Cells[0].Value);
            SqlCommand sqlcmd = new SqlCommand(sql, sqlconn);
            int count = sqlcmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("删除成功!");
                shuaxin();
            }
            else
            {
                MessageBox.Show("删除失败!");
            }
            sqlconn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
