using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 人事管理系统
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        NET net = new NET();
        //创建对象,引用类
        string sql = null;
        //声明

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            jiaZaiDataGridView();
            //加载黑道
            jiaDaiComboBox();
            //加载comboBox
        }

        private void jiaDaiComboBox()
        {
            try
            {//异常处理
                sql = string.Format("select * from Department");
                IDataAdapter ida = net.Sda(sql);
                DataSet ds = new DataSet();
                ida.Fill(ds);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "DeName";
                //显示值
                comboBox1.ValueMember = "DeId";
                //隐藏值
            }
            catch (Exception ex)
            {//异常处理提示
                MessageBox.Show(ex.Message, "来自系统提示");
            }//提示内容
            finally
            {
                net.NETClose();
            }//关闭数据库
        }

        private void jiaZaiDataGridView()
        {//方法加载黑道
            try
            {//异常处理
                sql = string.Format("select StNumber, StName, StSex, StTel, StIdentityCard, DeName from StaffInfo inner join Department on StaffInfo.DeId = Department.DeId");
                //数据库语句
                IDataAdapter ida = net.Sda(sql);
                //提供数据
                DataSet ds = new DataSet();
                //接收数据
                ida.Fill(ds);
                //填充数据
                dataGridView1.DataSource = ds.Tables[0];
                //给ta用
            }
            catch (Exception ex)
            {//异常处理提示
                MessageBox.Show(ex.Message, "来自系统提示");
            }//提示内容
            finally
            {
                net.NETClose();
            }//关闭数据库
        }

        /// <summary>
        /// 查询事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            chaXun();
            //查询方法
        }

        private void chaXun()
        {
            try
            {//异常处理
                sql = string.Format("select StNumber, StName, StSex, StTel, StIdentityCard, DeName from StaffInfo inner join Department on StaffInfo.DeId = Department.DeId   where Department.DeId = '{0}'", comboBox1.SelectedValue);
                //数据库语句
                IDataAdapter ida = net.Sda(sql);
                //提供数据
                DataSet ds = new DataSet();
                //接收数据
                ida.Fill(ds);
                //填充数据
                dataGridView1.DataSource = ds.Tables[0];
                //给ta用
            }
            catch (Exception ex)
            {//异常处理提示
                MessageBox.Show(ex.Message, "来自系统提示");
            }//提示内容
            finally
            {
                net.NETClose();
            }//关闭数据库
        }

        /// <summary>
        /// 右键删除事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {//异常处理
                if (MessageBox.Show("是否有要删除", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {//判断是否删除
                    sql = string.Format("delete from StaffInfo where StNumber = {0}", dataGridView1.SelectedRows[0].Cells[0].Value);
                    //数据库语句
                    if (net.Execute(sql) > 0)
                    {//受影响行数
                        MessageBox.Show("删除成功", "系统提示");
                        jiaZaiDataGridView();
                        //刷新
                    }
                    else
                    {
                        MessageBox.Show("删除失败", "系统提示");
                    }
                }
            }
            catch (Exception ex)
            {//异常处理提示
                MessageBox.Show(ex.Message, "来自系统提示");
            }//提示内容
            finally
            {
                net.NETClose();
            }//关闭数据库
        }
    }
}
