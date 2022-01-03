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
    public partial class AddUserAdministrator_10 : Form
    {
        public AddUserAdministrator_10()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.;uid=sa;pwd=123456;database=Book");

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label6.Text = dt.ToString("G");
        }

        private void AddUserAdministrator_10_Load(object sender, EventArgs e)
        {
            timer1.Start();
            jiazaiputong();
            jiazaiguanliyuan();            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            putozhi();
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            guanliyuanzhi();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            shanchuputong();
            jiazaiputong();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            shanchuguanliyuan();
            jiazaiguanliyuan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            putongmimachushihua();
            jiazaiputong();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            guanlimimachushihua();
            jiazaiguanliyuan();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            jiazaiputong();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            jiazaiguanliyuan();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            xuigaiputoyonghumingmima();
            jiazaiputong();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            xuigaiguanliyonghumingmima();
            jiazaiguanliyuan();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            guanliyuanbeiyongmimachushihua();
        }

        private void guanliyuanbeiyongmimachushihua()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("update [Administrator] set Akeys = 'AAAAAAAAAAAA' where AID = {0}", dataGridView2.SelectedRows[0].Cells[0].Value);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }//管理员备用密码初始化

        private void xuigaiguanliyonghumingmima()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("update [Administrator] set Aname = '{0}',Apwd = '{1}' where AID = {2}", textBox1.Text.Trim(), textBox2.Text.Trim(), dataGridView2.SelectedRows[0].Cells[0].Value);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }//修改管理员用户名密码

        private void xuigaiputoyonghumingmima()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("update [User] set Uname = '{0}' , Upwd = '{1}' where UID = {2}", textBox1.Text.Trim(), textBox2.Text.Trim(), dataGridView2.SelectedRows[0].Cells[0].Value);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }//修改普通用户用户名密码

        private void guanlimimachushihua()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("update [Administrator] set Apwd = '111111' where AID = {0}", dataGridView2.SelectedRows[0].Cells[0].Value);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }//管理员密码初始化

        private void putongmimachushihua()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("update [User] set Upwd = '111111' where Uid = {0}", dataGridView1.SelectedRows[0].Cells[0].Value);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }//普通用户密码初始化

        private void shanchuguanliyuan()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("delete from [Administrator] where AID = {0}", dataGridView2.SelectedRows[0].Cells[0].Value);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }//删除管理员用户

        private void shanchuputong()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("delete from [User] where Uid = {0}", dataGridView1.SelectedRows[0].Cells[0].Value);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }//删除普通用户

        private void jiazaiguanliyuan()
        {//加载管理员
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from [Administrator]");
                    SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];
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
        }//加载管理员

        private void guanliyuanzhi()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from [Administrator] where AID = {0}", dataGridView2.SelectedRows[0].Cells[0].Value);
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader sdr = com.ExecuteReader();
                    if (sdr.Read())
                    {
                        textBox1.Text = sdr["Aname"].ToString();
                        textBox2.Text = sdr["Apwd"].ToString();
                        label5.Text = sdr["AKeys"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("请勿选择空白区域", "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }//传值管理员

        private void jiazaiputong()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from [User]");
                    SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
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
        }//加载普通

        private void putozhi()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string sql = string.Format("select * from [User] where Uid = {0}", dataGridView1.SelectedRows[0].Cells[0].Value);
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader sdr = com.ExecuteReader();
                    if (sdr.Read())
                    {
                        textBox1.Text = sdr["Uname"].ToString();
                        textBox2.Text = sdr["Upwd"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("请勿选择空白区域", "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }//传值普通
    }
}
