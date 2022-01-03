using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 员工管理系统
{
    public partial class frmStaffAddAlter : Form
    {
        public frmStaffAddAlter()
        {
            InitializeComponent();
        }
        public int useID;//传递员工值
        private void button1_Click(object sender, EventArgs e)
        {
            if (useID == 0)
            {
                tianjia();
            }
            else
            {
                xuigai();

            }
        }
        /// <summary>
        /// 添加
        /// </summary>
        private void tianjia()
        {
            SqlConnection connection = new SqlConnection("server=.;uid=sa;pwd=123456;database=StaffManage");
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                string sex = null;
                if (radioButton1.Checked == true)
                {
                    sex = "男";
                }
                else
                {
                    sex = "女";
                }
                SqlCommand command = new SqlCommand(string.Format("insert  into T_Staff values('{0}','{1}','{2}',{3},'{4}',{5},{6})", textBox1.Text.Trim(), textBox2.Text.Trim(), sex, domainUpDown1.Text.Trim(), comboBox1.SelectedValue, domainUpDown2.Text.Trim(), textBox3.Text.Trim()), connection);
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("修改成功", "系统提示", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("修改失败", "系统提示", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("数据库未打开", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        private void xuigai()
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection("server=.;uid=sa;pwd=123456;database=StaffManage");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    string sex = null;
                    if (radioButton1.Checked == true)
                    {
                        sex = "男";
                    }
                    else if (radioButton2.Checked == true)
                    {
                        sex = "女";
                    }
                    SqlCommand command = new SqlCommand(string.Format(@"
                update T_Staff set Scard = '{0}',Sname = '{1}',Ssex = '{2}',Sage = {3},Saddress='{4}',SclassID='{5}',Swages={6} where SID = {0}",
                    textBox1.Text.Trim(), textBox2.Text.Trim(), sex, domainUpDown1.Text, textBox3.Text.Trim(), comboBox1.SelectedIndex + 1, domainUpDown2.Text, useID), connection);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("修改成功", "系统提示", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("修改失败", "系统提示", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("数据库未打开", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {//当数据库打开关闭
                    connection.Close();
                }
            }
        }

        private void frmStaffAddAlter_Load(object sender, EventArgs e)
        {//加载界面
            frmStaffHomepage frm = new frmStaffHomepage();
            //员工添加&修改
            if (useID == 0)
            {
                button1.Text = "添加";
            }
            else
            {
                button1.Text = "修改";
            }

            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection("server=.;uid=sa;pwd=123456;database=StaffManage");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    SqlCommand command = new SqlCommand(string.Format(@"select Scard, Sname, Ssex, Sage, Saddress, Swages, Cname from T_Staff inner join T_Class  on T_Class.CID = T_Staff.SclassID where SID = {0}", useID), connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    string sex = null;
                    if (dataReader.Read())
                    {
                        textBox1.Text = dataReader["Scard"].ToString();
                        textBox2.Text = dataReader["Sname"].ToString();
                        sex = dataReader["Ssex"].ToString();
                        if (sex == "男")
                        {
                            radioButton1.Checked = true;
                        }
                        else if (sex == "女")
                        {
                            radioButton2.Checked = true;
                        }
                        domainUpDown1.Text = dataReader["Sage"].ToString();                       
                        domainUpDown2.Text = dataReader["Swages"].ToString();
                        comboBox1.Text = dataReader["Cname"].ToString();
                        textBox3.Text = dataReader["Saddress"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("数据库未打开", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {//当数据库打开关闭
                    connection.Close();
                }
            }

        }

        private void domainUpDown1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 1; i <= 120; i++)
            {
                domainUpDown1.Items.Add(i);
            }
        }

        private void domainUpDown2_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 3000; i <= 100000; i++)
            {
                domainUpDown2.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            comboBox1.Text = null;
            radioButton1.Checked = true;
            domainUpDown1.Text = null;
            domainUpDown2.Text = null;
        }
    }
}
