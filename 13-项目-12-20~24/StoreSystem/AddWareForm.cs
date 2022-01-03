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
    public partial class AddWareForm : Form
    {
        public AddWareForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.;uid=sa;pwd=123456;database=StoreSystem");
        private void button3_Click(object sender, EventArgs e)
        {//添加按钮
            if (weiko())
            {
                addStore();
            }
        }

        private void addStore()
        {//添加
            try
            {
                con.Open();
                string sql = string.Format("insert into WareInfo values('{0}','{1}','{2}','{3}','{4}','{5}')", comboBox3.SelectedValue, textBox1.Text.Trim(), comboBox1.SelectedItem.ToString(), textBox2.Text.Trim(), comboBox2.SelectedIndex, textBox3.Text.Trim());
                SqlCommand com = new SqlCommand(sql, con);
                if (com.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("添加成功", "系统提示", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("添加失败", "系统提示", MessageBoxButtons.OK);
                }
                con.Close();
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

        private bool weiko()
        {//为空判断
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请填入商品名称", "系统提示");
                return false;
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("请填入商品总数", "系统提示");
                return false;
            }
            return true;
        }//为空判断

        private void AddWareForm_Load(object sender, EventArgs e)
        {
            Loada();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
        private void Loada()
        {//加载事件
            try
            {
                con.Open();
                string sql = string.Format("select * from  WareType");
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                DataSet set = new DataSet();
                sda.Fill(set);
                comboBox3.DataSource = set.Tables[0];//加载类别
                comboBox3.ValueMember = "wareTypeId";
                comboBox3.DisplayMember = "waerTypeName";
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

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
