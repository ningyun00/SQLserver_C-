using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 新睿学院学员管理
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        NET net = new NET();
        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {//异常处理
                jiazaidataGridView();
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
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {//异常处理
                chaxundataGridView();
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

        private void chaxundataGridView()
        {
            string sql = string.Format("select XRID, XRName, XRSex, XRBirthDay, XRAge, XRCName from XR_Student inner join XR_Class on XR_Student.XRclass = XR_Class.XRCID where XRName like '%{0}%'", textBox1.Text.Trim());
            //sql语句
            IDataAdapter ida = net.Sda(sql);
            //提供数据
            DataSet ds = new DataSet();
            //接受数据
            ida.Fill(ds);
            //填充
            dataGridView1.DataSource = ds.Tables[0];
            //给它使用
        }

        private void jiazaidataGridView()
        {
            string sql = string.Format("select XRID, XRName, XRSex, XRBirthDay, XRAge, XRCName from XR_Student inner join XR_Class on XR_Student.XRclass = XR_Class.XRCID");
            //sql语句
            IDataAdapter ida = net.Sda(sql);
            //提供数据
            DataSet ds = new DataSet();
            //接受数据
            ida.Fill(ds);
            //填充
            dataGridView1.DataSource = ds.Tables[0];
            //给它使用
        }
    }
}
