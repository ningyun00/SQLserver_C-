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
    public partial class WarePriceManage : Form
    {
        public WarePriceManage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//删除
        {
            if (MessageBox.Show("确定删除吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                shanchu();
            }
            else
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)//查询
        {
            shuaxin();
        }

        private void shuaxin()
        {
            SqlConnection sqlconn = null;
            try
            {
                sqlconn = new SqlConnection("server=.;uid=sa;pwd=123456;database=StoreSystem");
                sqlconn.Open();
                if (sqlconn.State == ConnectionState.Open)
                {

                    StringBuilder sb = new StringBuilder();
                    sb.Append(@"SELECT [wareTypeId],[wareName],[warePrice],[wareDiscount],[wareRemark] FROM [WareInfo] inner join WarePrice on [WareInfo].wareid=WarePrice.wareId ");
                    if (textBox1.Text.Trim() != null)//姓名
                    {
                        sb.AppendFormat(" and [wareName] like '%{0}%'", textBox1.Text.Trim());
                    }
                    SqlDataAdapter sda = new SqlDataAdapter(sb.ToString(), sqlconn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
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
            string sql = string.Format("delete from WarePrice where wareId='{0}'", dataGridView1.SelectedRows[0].Cells[0].Value);
            SqlCommand sqlcmd = new SqlCommand(sql, sqlconn);
            int count = sqlcmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("删除成功!");
                shuaxin();
            }
            sqlconn.Close();
        }
    }
}