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
    public partial class AddBock_04 : Form
    {
        public AddBock_04()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.;uid=sa;pwd=123456;database=Book");

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void AddBock_04_Load(object sender, EventArgs e)
        {
            jiazai();//加载类别            
            if (Data.bianhao > 0)
            {
                button1.Text = "修改";
                this.Text = "修改图书";
                jiazaixuigai();
            }
            else if (Data.bianhao == 0)
            {
                button1.Text = "添加";
            }
        }

        private void jiazaixuigai()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from [BookManage] where Bid = {0}", Data.bianhao);
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader sdr = com.ExecuteReader();
                    if (sdr.Read())
                    {
                        textBox1.Text = sdr["Bname"].ToString();
                        textBox2.Text = sdr["Bauthor"].ToString();
                        textBox3.Text = sdr["Bpress"].ToString();
                        textBox4.Text = sdr["Binventory"].ToString();
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
        }//加载修改

        private void button1_Click(object sender, EventArgs e)
        {
            if (non_null())
            {//不为空
                if (Data.bianhao > 0)
                {//修改
                    xuigai();
                }
                else if (Data.bianhao == 0)
                {
                    tianjia();
                }
            }
        }

        private void xuigai()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("update[BookManage] set Bname = '{0}', Bauthor = '{1}', Bpress = '{2}', Btypeid = {3}, Binventory = {4} where Bid = {5}", textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim(), comboBox1.SelectedValue, textBox4.Text.Trim(), Data.bianhao);
                    SqlCommand com = new SqlCommand(sql, con);
                    if (com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("修改成功", "系统提示");
                    }
                    else
                    {
                        MessageBox.Show("修改失败", "系统提示");
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
                    string sql = string.Format("insert into [BookManage] values('{0}','{1}','{2}',{3},{4})", textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim(), comboBox1.SelectedValue, textBox4.Text.Trim());
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

        private void jiazai()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from Class");
                    SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    comboBox1.DataSource = ds.Tables[0];
                    comboBox1.ValueMember = "BtypeID";//隐藏
                    comboBox1.DisplayMember = "Ctype";//显示                    
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
        }//加载类别



        private bool non_null()
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入书名", "系统提示");
                return false;
            }
            if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入作者", "系统提示");
                return false;
            }
            if (textBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入出版社", "系统提示");
                return false;
            }
            if (textBox4.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入库存", "系统提示");
                return false;
            }
            return true;
        }//非空验证
    }
}
