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
    public partial class AddWarePriceForm : Form
    {
        public AddWarePriceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection("server=. ; uid=sa ; pwd=123456 ; database=StoreSystem");
            sqlconn.Open();
            string sql = string.Format("update WarePrice set warePrice='{0}',wareDiscount='{1}',Remark='{2}' from WarePrice inner join WareInfo on [WarePrice].wareId=[WareInfo].wareId where wareName='{3}'", textBox3.Text, textBox1.Text, textBox2.Text, comboBox1.Text);
            SqlCommand sqlcmd = new SqlCommand(sql, sqlconn);
            int jg = sqlcmd.ExecuteNonQuery();
            if (jg > 0)
            {
                MessageBox.Show("成功保存！", "系统提示");
            }
            else
            {
                MessageBox.Show("修改保存！", "系统提示");
            }
            sqlconn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WJD()//无间道
        {
            SqlConnection sqlconn = new SqlConnection("server=.;uid=sa;pwd=123456;database=StoreSystem");
            sqlconn.Open();
            //3>.写SQL语句:
            string sql = string.Format(@"select * from WareInfo");
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlconn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.ValueMember = "wareId";
            comboBox1.DisplayMember = "wareName";
            sqlconn.Close();
        }

        private void AddWarePriceForm_Load(object sender, EventArgs e)
        {
            WJD();
            comboBox1.SelectedIndex = 2;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection("server=.;uid=sa;pwd=123456;database=StoreSystem");
            sqlconn.Open();
            //3>.写SQL语句:
            string sql = string.Format(@"select * from  WarePrice where wareId = '{0}'", comboBox1.SelectedValue);
            SqlCommand com = new SqlCommand(sql, sqlconn);
            SqlDataReader sdr = com.ExecuteReader();
            if (sdr.Read())
            {
                textBox3.Text = sdr["warePrice"].ToString();
                textBox1.Text = sdr["wareDiscount"].ToString();
            }
            sqlconn.Close();
        }
        public double A;
        private void jisuan()
        {
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("请填入折扣", "系统提示");
                return;
            }
            if (Convert.ToDouble(textBox4.Text) >= 0.1 && Convert.ToDouble(textBox4.Text) <= 0.9)
            {
                A = Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox4.Text);
                textBox1.Text = A.ToString();
            }
            else
            {
                MessageBox.Show("折扣输入不规范", "系统提示");
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jisuan();
        }
    }
}