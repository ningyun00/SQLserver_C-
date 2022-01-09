using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 新睿学院学员管理
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        NET net = new NET();
        //实例化对象
        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {//加载事件
            try
            {//异常处理
                jaizaiClass();
                //加载班级
            }
            catch (Exception ex)
            {//异常处理提示
                MessageBox.Show(ex.Message, "来自系统提示");
            }
            finally
            {//关闭数据库
                net.NETClose();
            }
        }

        private void jaizaiClass()
        {//加载班级方法
            string sql = string.Format("select * from XR_Class");
            //数据库sql执行语句
            IDataAdapter ida = net.Sda(sql);
            //申明一个接口、用来提供数据
            DataSet ds = new DataSet();
            //接收数据
            ida.Fill(ds);
            //填充
            comboBox1.DataSource = ds.Tables[0];            
            comboBox1.ValueMember = "XRCID";
            //隐藏值
            comboBox1.DisplayMember = "XRCName";
            //显示值
        }

        private bool nun_null()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请输入姓名", "系统提示");
                return false;
            }
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请输入年龄", "系统提示");
                return false;
            }
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请输入出生日期", "系统提示");
                return false;
            }
            return true;
        }
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {//异常处理
                if (nun_null())
                {//非空验证
                    addStudent();
                    //添加学员
                }
            }
            catch (Exception ex)
            {//异常处理提示
                MessageBox.Show(ex.Message, "来自系统提示");
            }
            finally
            {//关闭数据库
                net.NETClose();
            }
        }
        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            radioButton1.Checked = true;
            comboBox1.SelectedIndex = 0;
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void addStudent()
        {//添加学员方法
            string sql = string.Format("insert into XR_Student values('{0}','{1}','{2}',{3},'{4}')", textBox1.Text.Trim(), radioButton1.Checked == true ? "男" : "女", textBox3.Text.Trim(), textBox2.Text.Trim(), comboBox1.SelectedValue);
            //数据库sql执行语句
            IDbCommand idc = net.Com(sql);
            //执行命令
            if (idc.ExecuteNonQuery() > 0)
            {//返回受影响的行数
                MessageBox.Show("添加成功", "系统提示");
            }
            else
            {
                MessageBox.Show("添加失败", "系统提示");
            }
        }
    }
}
