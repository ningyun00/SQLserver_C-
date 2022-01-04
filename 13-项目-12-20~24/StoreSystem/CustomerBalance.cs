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
    public partial class CustomerBalance : Form
    {
        public CustomerBalance()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;uid=sa;pwd=123456;database=StoreSystem");
        private int sum;
        private int danjia;
        private int ID;
        private int maney;
        private void CustomerBalance_Load(object sender, EventArgs e)
        {
            lurushangpin();//加载填入商品
            shangpliebiao();//商品
        }

        private void lurushangpin()
        {
            try
            {
                //连接数据库
                con.Open();
                if (con.State == ConnectionState.Open)
                {//打开数据库
                    string sql = string.Format("select wareId,wareName from WareInFo");
                    SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    comboBox1.DataSource = ds.Tables[0];
                    comboBox1.DisplayMember = "wareName";
                    comboBox1.ValueMember = "wareId";
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
        }//加载填入商品

        private void button1_Click(object sender, EventArgs e)
        {
            tianjiajinqu();//添加购买商品
        }

        private void shangpliebiao()
        {
            try
            {
                //连接数据库
                con.Open();
                if (con.State == ConnectionState.Open)
                {//打开数据库
                    string sql = string.Format("select WareInFo.wareId,wareName, warePrice from WareInFo inner join WarePrice on WareInFo.wareId = WarePrice.wareId; ");
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
        }

        private void tianjiajinqu()
        {
            try
            {
                //连接数据库
                con.Open();
                if (con.State == ConnectionState.Open)
                {//打开数据库
                    string sql = string.Format("select WareInFo.wareId,wareName,warePrice from WareInFo inner join WarePrice on WareInFo.wareId = WarePrice.wareId where WareInFo.wareId = '{0}'", comboBox1.SelectedValue);
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader sde = com.ExecuteReader();
                    if (sde.Read())
                    {
                        ListViewItem item = new ListViewItem(sde["wareName"].ToString());//创建行(必须创建第1行)
                        listView1.Items.Add(item);
                        listView1.Items[0].Selected = true;
                        ID = Convert.ToInt32(sde["wareId"].ToString());
                        maney = Convert.ToInt32(sde["warePrice"].ToString());
                        danjia = Convert.ToInt32(sde["warePrice"].ToString());
                        sum = sum + danjia;
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
        }//添加购买商品

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sum.ToString(), "系统提示");
            textBox2.Text = "您购买了：" + (Convert.ToInt32(listView1.Items.Count)-1) + "件商品。\n总价格是：" + sum + "元";
            try
            {
                //连接数据库
                con.Open();
                if (con.State == ConnectionState.Open)
                {//打开数据库
                    string sql = string.Format("select WareInFo.wareId,wareName, warePrice from WareInFo inner join WarePrice on WareInFo.wareId = WarePrice.wareId where WareInfo.wareId = {0}", ID);
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            sum = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.Items[0]);
                sum = sum - danjia;
            }
            else
            {
                MessageBox.Show("请选择要删除的项", "系统提示");
            }
        }
    }
}
