using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 图书管理系统
{
    public partial class ReturnBook_07 : Form
    {
        public ReturnBook_07()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.;uid=sa;pwd=123456;database=Book");

        DateTime dt = DateTime.Now;

        private void ReturnBook_07_Load(object sender, EventArgs e)
        {
            loadin();//加载
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.state == "管理员")
            {
                guihuan();//归还
                loadin();
            }
            else
            {
                MessageBox.Show("您的权限不够请联系管理员(3174902862@qq.com)", "系统提示");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Data.state == "管理员")
            {
                chaxunguihuan();
            }
            else
            {
                MessageBox.Show("您的权限不够请联系管理员(3174902862@qq.com)", "系统提示");
            }
        }//查询归还图书

        private void button3_Click(object sender, EventArgs e)
        {
            if (Data.state == "管理员")
            {
                chaxunweiguihuan();
            }
            else
            {
                MessageBox.Show("您的权限不够请联系管理员(3174902862@qq.com)", "系统提示");
            }
        }//查询未归还图书

        private void button4_Click(object sender, EventArgs e)
        {
            loadin();//加载
        }//查询所有

        private void button5_Click(object sender, EventArgs e)
        {
            if (Data.state == "管理员")
            {
                shanchu();
                loadin();
            }
            else
            {
                MessageBox.Show("您的权限不够请联系管理员(3174902862@qq.com)", "系统提示");
            }
        }//删除

        private void shanchu()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("delete from BooksBorrow where Bid ={0}", dataGridView1.SelectedRows[0].Cells[0].Value);
                    SqlCommand com = new SqlCommand(sql, con);
                    if (com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("删除成功", "系统提示");
                    }
                    else
                    {
                        MessageBox.Show("删除失败", "系统提示");
                    }
                }
                else
                {
                    MessageBox.Show("数据库未打开", "系统提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }//删除

        private void chaxunweiguihuan()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from BooksBorrow  where Bremarks not like '%已归还%'");
                    SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("数据库未打开", "系统提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }//查询未归还图书

        private void chaxunguihuan()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from BooksBorrow  where Bremarks like '%已归还%'");
                    SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("数据库未打开", "系统提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }//查询归还

        private void guihuan()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("update BooksBorrow set BreturnTime= '{0}',Bremarks='{1}' where Bid = {2}", dt.ToString("G"), "图书已归还", dataGridView1.SelectedRows[0].Cells[0].Value);
                    SqlCommand com = new SqlCommand(sql, con);
                    if (com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("归还成功", "系统提示");
                    }
                    else
                    {
                        MessageBox.Show("归还失败", "系统提示");
                    }
                }
                else
                {
                    MessageBox.Show("数据库未打开", "系统提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }//归还

        private void loadin()//加载
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from BooksBorrow");
                    SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("数据库未打开", "系统提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
