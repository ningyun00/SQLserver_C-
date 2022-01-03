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
    public partial class MyBookrack_12 : Form
    {
        public MyBookrack_12()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.;uid=sa;pwd=123456;database=Book");

        private void MyBookrack_12_Load(object sender, EventArgs e)
        {
            if (Data.state == "管理员")
            {
                jiazai1();
                dataGridView1.Hide();
            }
            else
            {
                jiazai();
                dataGridView2.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.state == "管理员")
            {
                shanchu1();
                jiazai1();
            }
            else
            {
                shanchu();
                jiazai();
            }
        }


        private void jiazai1()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from MyBookshelfKeeper");
                    SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];
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

        private void shanchu1()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("delete from [MyBookshelfKeeper] where GID ={0}", dataGridView2.SelectedRows[0].Cells[0].Value);
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
        }

        private void jiazai()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from MyBookrack");
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

        private void shanchu()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("delete from [MyBookrack] where Mid ={0}", dataGridView1.SelectedRows[0].Cells[0].Value);
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Data.state == "管理员")
            {
                jiazai1();
            }
            else
            {
                jiazai();
            }
        }
    }
}
