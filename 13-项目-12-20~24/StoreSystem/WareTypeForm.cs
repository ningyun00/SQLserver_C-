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
    public partial class WareTypeForm : Form
    {
        public WareTypeForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;uid=sa;pwd=123456;database=StoreSystem");
        private bool weikong()
        {//判断是否为空
            if (txtWareTypeName.Text == string.Empty)
            {
                MessageBox.Show("请输入商品名称", "系统提示", MessageBoxButtons.OK);
                return false;
            }
            if (txtRemark.Text == string.Empty)
            {
                MessageBox.Show("请输入商品备注", "系统提示", MessageBoxButtons.OK);
                return false;
            }
            if (gbWareType.Text == string.Empty)
            {
                MessageBox.Show("请选择商品类型商品", "系统提示", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }//为空判断

        private void WareTypeForm_Load(object sender, EventArgs e)
        {//加载事件
            longin();
        }//加载无间道

        private void longin()
        {//加载事件
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {//打开数据库
                    string sql = string.Format("select * from wareType");//查询
                    SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);//填充
                    this.gbWareType.DataSource = ds.Tables[0];
                    this.gbWareType.ValueMember = "wareTypeId";//获取隐藏值方式：   无间道名.SelectedValue
                    this.gbWareType.DisplayMember = "waerTypeName";//获取显示值方式： 无间道名.SelectedText
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (weikong())
            {
                chaxun();
                if (A == true)
                {
                    addware();//添加商品
                    longin();
                }
            }
        }
        public bool A;
        private void chaxun()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {//打开数据库
                    string sql = string.Format("select * from wareType where waerTypeName = '{0}'", txtWareTypeName.Text);//添加语句
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader sdr = com.ExecuteReader();
                    if (sdr.Read())
                    {
                        MessageBox.Show("已存在该类", "系统提示");
                        A = false;
                    }
                    else
                    {
                        A = true;
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
        }

        private void addware()
        {
            try
            {

                con.Open();
                if (con.State == ConnectionState.Open)
                {//打开数据库
                    string sql = string.Format("insert into WareType values('{0}','{1}')", txtWareTypeName.Text.Trim(), txtRemark.Text.Trim());//添加语句
                    SqlCommand cmd = new SqlCommand(sql, con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("添加成功", "系统提示", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("添加失败", "系统提示", MessageBoxButtons.OK);
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
        }//添加

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                shanchu();
                longin();
            }
            else
            {
                return;
            }

        }

        private void shanchu()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {//打开数据库
                    string sql = string.Format("delete from WareType where waerTypeName = '{0}'", txtWareTypeName.Text.Trim());//查询
                    SqlCommand com = new SqlCommand(sql, con);
                    if (com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("删除成功", "系统提示", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("删除失败", "系统提示", MessageBoxButtons.OK);
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
        }
    }
}
