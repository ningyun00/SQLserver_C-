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

namespace HotelManage
{
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        SqlConnection sqlc = new SqlConnection("server=.;uid=sa;pwd=123456;database=HotelManageDB");
        /// <summary>
        /// 将数据库中的内容填到combobox控件中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckIn_Load(object sender, EventArgs e)
        {
            jiazai1();//房间号
            jiazai2();//房间类型
        }

        private void jiazai2()
        {
            string sqlt = string.Format(@"select rtype from room");
            SqlDataAdapter sdat = new SqlDataAdapter(sqlt, sqlc);
            DataSet dst = new DataSet();
            sdat.Fill(dst);
            this.comboBox1.DataSource = dst.Tables[0];
            comboBox1.DisplayMember = "rtype";
            comboBox1.ValueMember = "rtype";
            sqlc.Close();            
        }

        private void jiazai1()
        {
            sqlc.Open();
            string sql = string.Format(@"select rno from room");
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlc);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "rno";
            comboBox2.ValueMember = "rid";
            sqlc.Close();
        }

        /// <summary>
        /// 把输入的值添加到数据库中
        /// </summary>
        public void into()
        {

        }

        /// <summary>
        /// 点击按钮将数据添加到数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (A == true)
            {
                into();
            }
        }

        public bool A;
        private void chaxun()
        {
            string a = string.Format(@"server=.;uid=sa;pwd=123456;database=HotelManageDB");
            SqlConnection sqlc = new SqlConnection(a);
            sqlc.Open();
            string sql = String.Format("Select  * from customer  where croom = '{0}'", name1);
            SqlCommand com = new SqlCommand(sql, sqlc);
            SqlDataReader sdr = com.ExecuteReader();
            if (sdr.Read())
            {
                MessageBox.Show("该房间已存在", "系统提示");
                A = false;
            }
            else
            {
                A = true;
            }
            sqlc.Close();
        }

        public static string name1;
        private void fangjian()
        {
            string a = string.Format(@"server=.;uid=sa;pwd=123456;database=HotelManageDB");
            SqlConnection sqlc = new SqlConnection(a);
            sqlc.Open();
            string sql = String.Format("Select  * from room  where rid = {0}", comboBox2.SelectedValue);
            SqlCommand com = new SqlCommand(sql, sqlc);
            SqlDataReader sdr = com.ExecuteReader();
            if (sdr.Read())
            {
                name1 = sdr["rno"].ToString();
            }
            sqlc.Close();
        }

    }
}
