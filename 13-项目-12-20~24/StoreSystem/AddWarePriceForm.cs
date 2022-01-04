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
        {//数据库连接字符串
            if (weiko())//为空判断
            {
                SqlConnection sqlconn = new SqlConnection("server=. ; uid=sa ; pwd=123456 ; database=StoreSystem");
                sqlconn.Open();//打开数据库
                string sql = string.Format("update WarePrice set warePrice='{0}',wareDiscount='{1}',Remark='{2}' from WarePrice inner join WareInfo on [WarePrice].wareId=[WareInfo].wareId where wareName='{3}'", textBox3.Text, textBox1.Text, textBox2.Text, comboBox1.Text);
                //修改
                SqlCommand sqlcmd = new SqlCommand(sql, sqlconn);
                //执行命令
                int jg = sqlcmd.ExecuteNonQuery();
                //传递结果,受影响的行数
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
        }

        private bool weiko()
        {
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("请输入商品价格", "系统提示");
                return false;
            }
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("请输入商品折扣价", "系统提示");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//取消
        }

        private void WJD()//无间道
        {
            SqlConnection sqlconn = new SqlConnection("server=.;uid=sa;pwd=123456;database=StoreSystem");
            sqlconn.Open();
            //3>.写SQL语句:
            string sql = string.Format(@"select * from WareInfo");
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlconn);
            DataSet ds = new DataSet();
            sda.Fill(ds);//填充
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.ValueMember = "wareId";//隐藏至
            comboBox1.DisplayMember = "wareName";//显示值
            sqlconn.Close();//关闭数据库
        }

        private void AddWarePriceForm_Load(object sender, EventArgs e)
        {
            WJD();//加载商品
            comboBox1.SelectedIndex = 2;//默认商品
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection("server=.;uid=sa;pwd=123456;database=StoreSystem");
            sqlconn.Open();
            //3>.写SQL语句:
            string sql = string.Format(@"select * from  WarePrice where wareId = '{0}'", comboBox1.SelectedValue);
            SqlCommand com = new SqlCommand(sql, sqlconn);//选中商品加载价格
            SqlDataReader sdr = com.ExecuteReader();
            if (sdr.Read())
            {
                textBox3.Text = sdr["warePrice"].ToString();//价格
                textBox1.Text = sdr["wareDiscount"].ToString();//折扣
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
            {//折扣计算
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