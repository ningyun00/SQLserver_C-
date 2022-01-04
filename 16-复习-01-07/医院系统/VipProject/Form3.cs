using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        NO1 no1 = new NO1();
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if ((int)dataGridView1.SelectedRows[0].Cells[0].Value > 0)
                {
                    string sql = string.Format("delete from patient where pID = {0}", (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                    if (no1.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功", "系统提示");
                    }
                    else
                    {
                        MessageBox.Show("删除失败", "系统提示");
                    }
                    no1.NO1Close();
                }
                else if (Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text) > 0)
                {
                    string sql = string.Format("delete from patient where pID = {0}", Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
                    if (no1.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功", "系统提示");
                    }
                    else
                    {
                        MessageBox.Show("删除失败", "系统提示");
                    }
                    no1.NO1Close();
                }
                dataGridViewload();
                listViewload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "来自系统提示");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewload();
                listViewload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "来自系统提示");
            }
        }

        private void listViewload()
        {//白道加载
            listView1.Items.Clear();
            //清除多余数据
            string sql = string.Format("select pID, pName, pAge, pSex, pExplain, doctorName from patient inner join Doctor on patient.doctorID = Doctor.doctorID where 1=1 and pName like '%{0}%'", textBox1.Text.Trim());
            //数据库执行语句
            IDataReader idr = no1.Sdr(sql);
            //读取数据
            while (idr.Read())
            {//填充数据
                ListViewItem Item = new ListViewItem(idr[0].ToString());
                Item.SubItems.Add(idr[1].ToString());
                Item.SubItems.Add(idr[2].ToString());
                Item.SubItems.Add(idr[3].ToString());
                Item.SubItems.Add(idr[4].ToString());
                Item.SubItems.Add(idr[5].ToString());
                listView1.Items.Add(Item);
            }
            no1.NO1Close();
            //关闭数据库
        }

        private void dataGridViewload()
        {//黑道加载
            string sql = string.Format("select pID, pName, pAge, pSex, pExplain, doctorName from patient inner join Doctor on patient.doctorID = Doctor.doctorID where 1=1 and pName like'%{0}%'", textBox1.Text.Trim());
            //数据库执行语句
            IDataAdapter idr = no1.Sda(sql);
            //提供数据
            DataSet ds = new DataSet();
            //接受数据
            idr.Fill(ds);
            //填充数据
            dataGridView1.DataSource = ds.Tables[0];
            //给dataGridView使用
            no1.NO1Close();
            //关闭数据库
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewload();
                listViewload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "来自系统提示");
            }
        }
    }
}
