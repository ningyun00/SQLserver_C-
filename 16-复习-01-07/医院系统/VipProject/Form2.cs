using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        NO1 no1 = new NO1();
        private void Form2_Load(object sender, EventArgs e)
        {//加载班级下拉框
            try
            {//异常处理
                string sql = string.Format("select * from Doctor");
                //数据库sql语句
                IDataAdapter ida = no1.Sda(sql);
                //申明一个接口、用来提供数据
                DataSet ds = new DataSet();
                //接收数据
                ida.Fill(ds);
                //填充数据
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "doctorName";
                //显示值
                comboBox1.ValueMember = "doctorID";
                //隐藏值
            }
            catch (Exception ex)
            {//异常处理提示
                MessageBox.Show(ex.Message, "来自系统提示");
            }
            finally
            {//关闭数据库
                no1.NO1Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {//添加
            try
            {//异常处理
                if (nun_null())
                {//非空验证
                    string sql = string.Format("insert into patient values('{0}', {1}, '{2}', '{3}', {4})", textBox1.Text.Trim(), textBox2.Text.Trim(), radioButton1.Checked == true ? "男" : "女", textBox3.Text.Trim(), comboBox1.SelectedValue);
                    //数据库sql语句
                    IDbCommand idc = no1.Com(sql);
                    //访问com命令
                    if (idc.ExecuteNonQuery() > 0)
                    {//成功
                        MessageBox.Show("添加成功");
                    }
                    else
                    {//失败
                        MessageBox.Show("添加失败");
                    }
                }
            }
            catch (Exception ex)
            {//异常处理提示
                MessageBox.Show(ex.Message, "来自系统提示");
            }
            finally
            {//关闭数据库
                no1.NO1Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {//取消
            Close();
        }
        private bool nun_null()
        {//非空验证
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请输入姓名", "系统提示");
                return false;
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("请输入年龄", "系统提示");
                return false;
            }
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("请输入病因", "系统提示");
                return false;
            }
            return true;
        }
    }
}
