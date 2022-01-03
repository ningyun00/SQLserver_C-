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
    public partial class BorrowBook_05 : Form
    {
        public BorrowBook_05()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.;uid=sa;pwd=123456;database=Book");

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.state == "管理员")
            {
                tianjia();//添加
            }
            else
            {
                MessageBox.Show("您的权限不够请联系管理员(3174902862@qq.com)", "系统提示");
            }
        }

        private void tianjia()
        {//添加
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == " AddBorrow_06")
                {//图书管理
                    item.BringToFront();
                    return;
                }
            }
            Data.renyuanbianhao = 0;
            AddBorrow_06 addBorrow = new AddBorrow_06();
            addBorrow.MdiParent = this.MdiParent;
            addBorrow.Show();
        }

        private void BorrowBook_05_Load(object sender, EventArgs e)
        {//加载
            loadin();
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (Data.state == "管理员")
            {
                xuigai();//修改         
            }
            else
            {
                MessageBox.Show("您的权限不够请联系管理员(3174902862@qq.com)", "系统提示");
            }
        }
        private void xuigai()//修改
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == " AddBorrow_06")
                {//图书管理
                    item.BringToFront();
                    return;
                }
            }
            AddBorrow_06 addBorrow = new AddBorrow_06();
            Data.renyuanbianhao = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            addBorrow.MdiParent = this.MdiParent;
            addBorrow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {//查询
            chaxun();
        }

        private void chaxun()
        {//查询
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(@"select * from BooksBorrow where  1 = 1  ");
                    if (textBox1.Text != string.Empty)
                    {
                        //    sb.AppendFormat("  or Bid like '%{0}%'", textBox1.Text.Trim());
                        //    sb.AppendFormat("  and Bbookname like '%{0}%'", textBox1.Text.Trim());
                        sb.AppendFormat("  and Bname like '%{0}%'", textBox1.Text.Trim());
                        //sb.AppendFormat("  or Bsex like '%{0}%'", textBox1.Text.Trim());
                        //sb.AppendFormat("  or Bage like '%{0}%'", textBox1.Text.Trim());
                        //sb.AppendFormat("  or Bphone like '%{0}%'", textBox1.Text.Trim());
                        //sb.AppendFormat("  or Baddress like '%{0}%'", textBox1.Text.Trim());
                        //sb.AppendFormat("  or Btime like '%{0}%'", textBox1.Text.Trim());
                        //sb.AppendFormat("  or BreturnTime like '%{0}%'", textBox1.Text.Trim());
                        //sb.AppendFormat("  or Bremarks like '%{0}%'", textBox1.Text.Trim());
                    }
                    SqlDataAdapter sda = new SqlDataAdapter(sb.ToString(), con);
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
