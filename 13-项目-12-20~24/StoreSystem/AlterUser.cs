using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StoreSystem
{
    public partial class AlterUser : Form
    {
        public AlterUser()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AlterUser_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconn = null;
            try
            {
                sqlconn = new SqlConnection("server= .;uid= sa;pwd= 123456;database= StoreSystem ");
                sqlconn.Open();
                string sql = string.Format("select * from UserInfo where Userid = {0}", UserInfoManage.A);
                SqlCommand com = new SqlCommand(sql, sqlconn);
                SqlDataReader sdr = com.ExecuteReader();
                if (sdr.Read())
                {
                    textBox1.Text = sdr["username"].ToString();
                    textBox2.Text = sdr["userpassword"].ToString();
                    textBox3.Text = sdr["usertelphone"].ToString();
                    textBox4.Text = sdr["userremark"].ToString();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误提示");
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }
        }
    }
}
