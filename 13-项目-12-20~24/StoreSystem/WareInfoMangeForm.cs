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
    public partial class WareInfoMangeForm : Form
    {
        public WareInfoMangeForm()
        {
            InitializeComponent();
        }        
        int sx = 0;
        private void sjcx()//上架查询
        {
            SqlConnection sqlconn = new SqlConnection("server=.; uid=sa; pwd=123456; database=StoreSystem");
            sqlconn.Open();
            string sql = string.Format("select wareId as 'ID',wareName as '商品名称' ,wareLevel as '商品级别',wareTotalNumber as '商品数量',wareRemark as '商品备注' from WareInfo where wareUpAndDown=1");
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlconn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            sx = 0;
        }

        private void xjcx()//下架查询
        {
            SqlConnection sqlconn = new SqlConnection("server=.; uid=sa; pwd=123456; database=StoreSystem");
            sqlconn.Open();
            string sql = string.Format("select  wareId as 'ID',wareName as '商品名称' ,wareLevel as '商品级别',wareTotalNumber as '商品数量',wareRemark as '商品备注' from WareInfo where wareUpAndDown=0");
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlconn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            sx = 1;
        }


        private void button3_Click(object sender, EventArgs e)//上架商品查询
        {
            sjcx();
        }

        private void button1_Click(object sender, EventArgs e)//下架商品查询
        {
            xjcx();
        }

        private void button5_Click(object sender, EventArgs e)//删除商品
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

        private void shanchu()
        {
            SqlConnection sqlconn = new SqlConnection("server= .;uid= sa;pwd= 123456;database= StoreSystem");
            sqlconn.Open();
            string sql = string.Format("delete from WareInfo where wareID='{0}'", dataGridView1.SelectedRows[0].Cells[0].Value);
            SqlCommand sqlcmd = new SqlCommand(sql, sqlconn);
            int count = sqlcmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("删除成功!");
                if (sx == 0)
                {
                    sjcx();
                }
                if (sx == 1)
                {
                    xjcx();
                }
            }
            sqlconn.Close();
        }

        private void spxj()//商品下架
        {
            SqlConnection sqlconn = null;
            try
            {
                sqlconn = new SqlConnection("server=.;uid=sa;pwd=123456;database=StoreSystem");
                sqlconn.Open();
                if (sqlconn.State == ConnectionState.Open)
                {
                    string sql = string.Format("update WareInfo set wareUpAndDown=0  where wareID='{0}'", dataGridView1.SelectedRows[0].Cells[0].Value);
                    SqlCommand sqlcmd = new SqlCommand(sql, sqlconn);
                    int jg = sqlcmd.ExecuteNonQuery();
                    if (jg > 0)
                    {
                        MessageBox.Show("商品已下架", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sjcx();
                    }
                    else
                    {
                        MessageBox.Show("下架失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
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

        private void button4_Click(object sender, EventArgs e)
        {
            spxj();//商品下架

        }


        private void spsj()//商品上架
        {
            SqlConnection sqlconn = null;
            try
            {
                sqlconn = new SqlConnection("server=.;uid=sa;pwd=123456;database=StoreSystem");
                sqlconn.Open();
                if (sqlconn.State == ConnectionState.Open)
                {
                    string sql = string.Format("update WareInfo set wareUpAndDown=1  where wareID='{0}'", dataGridView1.SelectedRows[0].Cells[0].Value);
                    SqlCommand sqlcmd = new SqlCommand(sql, sqlconn);
                    int jg = sqlcmd.ExecuteNonQuery();
                    if (jg > 0)
                    {
                        MessageBox.Show("商品已上架", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        xjcx();
                    }
                    else
                    {
                        MessageBox.Show("上架失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {//商品上架
            spsj();
        }

        private void WJD()//无间道
        {
            SqlConnection sqlconn = new SqlConnection("server=.;uid=sa;pwd=123456;database=StoreSystem");
            sqlconn.Open();
            //3>.写SQL语句:
            string sql = string.Format(@"select * from WareType");
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlconn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.ValueMember = "wareTypeId";
            comboBox1.DisplayMember = "waerTypeName";
            sqlconn.Close();
            

        }

        private void WareInfoMangeForm_Load(object sender, EventArgs e)
        {
            WJD();//无间道
        }

        private void cx()//商品类的查询
        {
            SqlConnection sqlconn = new SqlConnection("server=.;uid=sa;pwd=123456;database=StoreSystem");
            sqlconn.Open();
            string sql = string.Format(@"select  wareId as 'ID',wareName as '商品名称' ,wareLevel as '商品级别',wareTotalNumber as '商品数量',wareRemark as '商品备注' from WareInfo inner join WareType on [WareInfo].wareTypeId=[WareType].wareTypeId where waerTypeName='{0}'", comboBox1.Text);
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlconn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            sqlconn.Close();

        }


        private void button6_Click(object sender, EventArgs e)
        {
            cx();
        }
    }
}
