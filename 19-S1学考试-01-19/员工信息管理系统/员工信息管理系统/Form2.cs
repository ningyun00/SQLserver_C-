using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 员工信息管理系统
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        NET net = new NET();
        //实例化对象,应用类
        string sql = null;
        //声明字符串

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            jiaZaiComboBox();
        }
        /// <summary>
        /// 加载下拉框
        /// </summary>
        private void jiaZaiComboBox()
        {
            try
            {//异常处理
                sql = string.Format("select * from PostRank");
                //数据库执行命令
                IDataAdapter ida = net.Sda(sql);
                //提供数据
                DataSet ds = new DataSet();
                //接收数据
                ida.Fill(ds);
                //填充数据
                comboBox1.DataSource = ds.Tables[0];                
                comboBox1.DisplayMember = "PostRankName";
                //显示值
                comboBox1.ValueMember = "id";
                //隐藏值
            }
            catch (Exception ex)
            {//异常处理提示
                MessageBox.Show(ex.Message, "来自系统提示");
            }
            finally
            {//一定执行
                net.NETClose();
                //关闭数据库
            }
        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (nun_null())
            {//不为空
                try
                {//异常处理
                    sql = string.Format("insert into Employees values('{0}', '{1}', '{2}', {3}, '{4}', '{5}', '{6}')", textBox1.Text.Trim(), textBox2.Text.Trim(), dateTimePicker1.Value.ToString(), comboBox1.SelectedValue, dateTimePicker2.Value.ToString(), textBox3.Text.Trim(), radioButton1.Checked == true ? "男" : "女");
                    //数据库执行命令
                    if (net.Execute(sql) > 0)
                    {//受影响的行数
                        MessageBox.Show("恭喜, 添加成功", "系统提示");
                        //添加成功
                    }
                    else
                    {
                        MessageBox.Show("添加失败", "系统提示");
                        //添加失败
                    }
                }
                catch (Exception ex)
                {//异常处理提示
                    MessageBox.Show(ex.Message, "来自系统提示");
                }
                finally
                {//一定执行
                    net.NETClose();
                    //关闭数据库
                }
            }
        }
        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns></returns>
        private bool nun_null()
        {
            if (textBox1.Text.Trim() == string.Empty)
            {//文本框一
                MessageBox.Show("请填写所有完整信息后提交", "系统提示");
                return false;
            }
            if (textBox2.Text.Trim() == string.Empty)
            {//文本框二
                MessageBox.Show("请填写所有完整信息后提交", "系统提示");
                return false;
            }
            if (textBox3.Text.Trim() == string.Empty)
            {//文本框三
                MessageBox.Show("请填写所有完整信息后提交", "系统提示");
                return false;
            }
            return true;
            //没有空
        }

        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            //空
            textBox2.Text = string.Empty;
            //空
            textBox3.Text = string.Empty;
            //空
            comboBox1.SelectedIndex = 0;
            //一
            radioButton1.Checked = true;
            //男
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            //关闭页面
        }
    }
}
