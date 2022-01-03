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
    public partial class AddBorrow_06 : Form
    {
        public AddBorrow_06()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.;uid=sa;pwd=123456;database=Book");

        DateTime dt = DateTime.Now;

        private void AddBorrow_06_Load(object sender, EventArgs e)//加载
        {
            if (Data.renyuanbianhao > 0)
            {
                button1.Text = "修改";
                jiazaixuigai();
            }
            else
            {
                button1.Text = "添加";
                textBox6.Text = dt.ToString();
            }
        }

        private void jiazaixuigai()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from BooksBorrow  where Bid = {0}", Data.renyuanbianhao);
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader sdr = com.ExecuteReader();
                    if (sdr.Read())
                    {
                        textBox1.Text = sdr["BbookName"].ToString();
                        textBox2.Text = sdr["Bname"].ToString();
                        string sex = sdr["Bsex"].ToString();
                        if (sex == "男")
                        {
                            radioButton1.Checked = true;
                        }
                        else
                        {
                            radioButton2.Checked = true;
                        }
                        textBox3.Text = sdr["Bage"].ToString();
                        textBox4.Text = sdr["Bphone"].ToString();
                        textBox5.Text = sdr["Baddress"].ToString();
                        textBox6.Text = sdr["Btime"].ToString();
                        textBox7.Text = sdr["BreturnTime"].ToString();
                        textBox8.Text = sdr["Bremarks"].ToString();
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
        }//加载修改项


        private void button1_Click(object sender, EventArgs e)
        {
            if (nun_null())
            {
                if (Data.renyuanbianhao > 0)
                {
                    xuigai();

                }
                else if(Data.renyuanbianhao==0)
                {
                    tianjia();
                    click();
                }
            }
        }

        private void click()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
        }

        private void xuigai()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sex = string.Empty;
                    if (radioButton1.Checked == true)
                    {
                        sex = "男";
                    }
                    else
                    {
                        sex = "女";
                    }
                    string sql = string.Format("update BooksBorrow set BbookName = '{0}', Bname = '{1}', Bsex = '{2}', Bage = {3}, Bphone = {4}, Baddress = '{5}', Btime = '{6}', BreturnTime = '{7}', Bremarks = '{8}' where Bid = {9}", textBox1.Text.Trim(), textBox2.Text.Trim(), sex, textBox3.Text.Trim(), textBox4.Text.Trim(), textBox5.Text.Trim(), textBox6.Text.Trim(), textBox7.Text.Trim(), textBox8.Text.Trim(), Data.renyuanbianhao);
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
        }//修改

        private void tianjia()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sex = string.Empty;
                    if (radioButton1.Checked == true)
                    {
                        sex = "男";
                    }
                    else
                    {
                        sex = "女";
                    }
                    string sql = string.Format("insert into BooksBorrow values('{0}','{1}','{2}',{3},{4},'{5}','{6}','{7}','{8}')", textBox1.Text.Trim(), textBox2.Text.Trim(), sex, textBox3.Text.Trim(), textBox4.Text.Trim(), textBox5.Text.Trim(), textBox6.Text.Trim(), textBox7.Text.Trim(), textBox8.Text.Trim());
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
        }//添加

        private bool nun_null()
        {//非空验证
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入书籍名称", "系统提示");
                return false;
            }
            if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入借阅人姓名", "系统提示");
                return false;
            }
            if (textBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入借阅人年龄", "系统提示");
                return false;
            }
            if (textBox4.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入借阅人电话号码", "系统提示");
                return false;
            }
            if (textBox5.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入借阅人家庭住址", "系统提示");
                return false;
            }
            if (textBox6.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入借阅时间", "系统提示");
                return false;
            }
            return true;
        }
    }
}
