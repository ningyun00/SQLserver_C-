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
    public partial class Librarian_03 : Form
    {
        public Librarian_03()
        {
            InitializeComponent();
        }
        public string name = null;//书名
        public string author = null;//作者
        public string name1 = null;//书名
        public string author1 = null;//作者

        SqlConnection con = new SqlConnection("server=.;uid=sa;pwd=123456;database=Book");

        private void Librarian_03_Load(object sender, EventArgs e)
        {
            timer1.Start();
            jiazai();
        }

        private void jiazai()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select Bid, Bname, Bauthor, Bpress, Ctype, Binventory from [BookManage] inner join [Class]  on [BookManage].Btypeid = [class].btypeid;");
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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == " AddBock_04")
                {//图书管理
                    item.BringToFront();
                    return;
                }
            }
            AddBock_04 addBock = new AddBock_04();
            addBock.MdiParent = this.MdiParent;
            Data.bianhao = 0;
            addBock.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == " AddBock_04")
                {//图书管理
                    item.BringToFront();
                    return;
                }
            }
            AddBock_04 addBock = new AddBock_04();
            Data.bianhao = (int)dataGridView1.SelectedRows[0].Cells[0].Value;//列下标
            addBock.MdiParent = this.MdiParent;
            addBock.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            jiazai();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Data.state == "管理员")
            {
                shanchu();
            }
            else
            {
                MessageBox.Show("您的权限不够请联系管理员(3174902862@qq.com)", "系统提示");
            }
        }

        private void shanchu()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("delete from [BookManage] where Bid = {0}", dataGridView1.SelectedRows[0].Cells[0].Value);
                    SqlCommand com = new SqlCommand(sql, con);
                    if (com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("删除成功", "系统提示");
                        jiazai();
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (nun_null())//非空判断
            {
                bianhaochaxun();
            }

        }

        private bool nun_null()
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入书籍查询编号", "系统提示");
                return false;
            }
            return true;
        }

        private void bianhaochaxun()//编号查询
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from [BookManage] where Bid like '%{0}%'", textBox1.Text.Trim());
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (nun_null1())
            {
                shumingchaxun();
            }
        }

        private void shumingchaxun()
        {//书名查询
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from [BookManage] where Bname like '%{0}%'", textBox2.Text.Trim());
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

        private bool nun_null1()
        {
            if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入书籍名称", "系统提示");
                return false;
            }
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label2.Text = dt.ToString("G");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Data.state == "管理员")
            {
                mybookrack1();//传值
                tianjia1();
            }
            else
            {
                mybookrack();//传值
                tianjia();
            }

        }

        private void tianjia1()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("insert into MyBookshelfKeeper values('{0}','{1}')", name1, author1);
                    SqlCommand com = new SqlCommand(sql, con);
                    if (com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("添加成功", "系统提示");
                    }
                    else
                    {
                        MessageBox.Show("添加失败", "系统提示");
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

        private void mybookrack1()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from [BookManage] where Bid = {0}", dataGridView1.SelectedRows[0].Cells[0].Value);
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader sdr = com.ExecuteReader();
                    if (sdr.Read())
                    {
                        name1 = sdr["Bname"].ToString();
                        author1 = sdr["Bauthor"].ToString();
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


        private void mybookrack()//传值
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from [BookManage] where Bid = {0}", dataGridView1.SelectedRows[0].Cells[0].Value);
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader sdr = com.ExecuteReader();
                    if (sdr.Read())
                    {
                        name = sdr["Bname"].ToString();
                        author = sdr["Bauthor"].ToString();
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
        private void tianjia()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("insert into MyBookrack values('{0}','{1}')", name, author);
                    SqlCommand com = new SqlCommand(sql, con);
                    if (com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("添加成功", "系统提示");
                    }
                    else
                    {
                        MessageBox.Show("添加失败", "系统提示");
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
    }
}
