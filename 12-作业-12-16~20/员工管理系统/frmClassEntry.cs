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
    public partial class frmClassEntry : Form
    {
        public frmClassEntry()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection("server=.;uid=sa;pwd=123456;database=StaffManage");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(String.Format("select * from T_Class where Cname like '%{0}%'", textBox1.Text.Clone()), connection);
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

        private void button2_Click(object sender, EventArgs e)
        {
            frmStaffHomepage homepage = new frmStaffHomepage();
            frmClassAddAlter frm = new frmClassAddAlter();
            frm.MdiParent = this.MdiParent;
            frm.A = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            homepage.zhi = 0;//修改
            frm.Show();

           

        }
    }
}
