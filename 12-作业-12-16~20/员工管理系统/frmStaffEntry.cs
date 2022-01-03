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
    public partial class frmStaffEntry : Form
    {
        public frmStaffEntry()
        {
            InitializeComponent();
        }
        private void frmStaffEntry_Load(object sender, EventArgs e)
        {//调用加载事件方法
            yuangobianhao();
            sousuobumenjiazai();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            try
            {//连接字符串
                connection = new SqlConnection("server=.;uid=sa;pwd=123456;database=StaffManage");
                //打开数据库
                connection.Open();
                //打开执行
                if (connection.State == ConnectionState.Open)
                {
                    StringBuilder @string = new StringBuilder();
                    //查询
                    @string.AppendFormat(@"select SID,Scard,Sname,Ssex,Sage,Saddress,Swages,Cname,Cremarks from T_Staff inner join T_Class  on T_Class.CID = T_Staff.SclassID ");
                    //查询不为空
                    if (textBox1.Text.Trim() != string.Empty)
                    {//查询工号
                        @string.AppendFormat("  and  Scard like '%{0}%'", textBox1.Text.Trim());
                    }
                    if (textBox2.Text.Trim() != string.Empty)
                    {//查询姓名
                        @string.AppendFormat("  and  Sname like '%{0}%'", textBox2.Text.Trim());
                    }
                    if (comboBox1.Text.Trim() != string.Empty)
                    {//查询部门
                        @string.AppendFormat("  and Cname like '%{0}%'", comboBox1.Text.Trim());
                    }
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(@string.ToString(), connection);
                    //容器，大
                    DataSet set = new DataSet();
                    //容器，小
                    dataAdapter.Fill(set);
                    //填充
                    dataGridView1.DataSource = set.Tables[0];
                    //显示在dataGridView
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
        #region 搜索部门加载
        private void sousuobumenjiazai()
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection("server=.;uid=sa;pwd=123456;database=StaffManage");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(string.Format("select * from T_Class"), connection);
                    DataSet set = new DataSet();
                    dataAdapter.Fill(set);
                    //填充到comboBox
                    comboBox1.DataSource = set.Tables[0];
                    //部门
                    comboBox1.DisplayMember = "Cname";
                    //部门编号
                    comboBox1.ValueMember = "CID";
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
        #endregion 
        #region  加载事件方法--DataGridView--ComboBox
        private void yuangobianhao()
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection("server=.;uid=sa;pwd=123456;database=StaffManage");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {//查询，两表连接
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(string.Format(@"select SID,Scard,Sname,Ssex,Sage,Saddress,Swages,Cname,Cremarks from T_Staff inner join T_Class  on T_Class.CID = T_Staff.SclassID"), connection);
                    DataSet set = new DataSet();
                    dataAdapter.Fill(set);
                    dataGridView1.DataSource = set.Tables[0];
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
        #endregion
        private void button2_Click(object sender, EventArgs e)
        {//员工修改
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType().Name == "frmStaffAddAlter")
                {
                    item.BringToFront();
                    return;
                }
            }
            frmStaffAddAlter staffAddAlter = new frmStaffAddAlter();
            staffAddAlter.useID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);//序号==1修改
            staffAddAlter.MdiParent = this.MdiParent;
            staffAddAlter.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("server=.;uid=sa;pwd=123456;database=StaffManage");
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand(string.Format(@"delete from T_Staff  where SID = {0}", dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), connection);//
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("删除成功", "提示");
                    yuangobianhao();
                }
                else
                {

                    MessageBox.Show("删除失败", "提示");
                }
            }
            else
            {
                MessageBox.Show("数据库未打开", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
