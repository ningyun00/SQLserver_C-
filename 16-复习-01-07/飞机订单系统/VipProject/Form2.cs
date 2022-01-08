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
        NET net = new NET();
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                formLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "来自系统提示");
            }
            finally
            {
                net.NETClose();
            }
        }

        private void formLoad()
        {
            listView1.Items.Clear();
            string sql = string.Format("select * from plane where 1=1 and LeaveCity like '%{0}%'and ArriveCity like '%{1}%'", Form1.start, Form1.end);
            IDataReader idr = net.Sdr(sql);
            while (idr.Read())
            {
                ListViewItem item = new ListViewItem(idr[0].ToString());
                item.SubItems.Add(idr[1].ToString());
                item.SubItems.Add(idr[2].ToString());
                item.SubItems.Add(idr[3].ToString());
                item.SubItems.Add(idr[4].ToString());
                item.SubItems.Add(idr[5].ToString());
                listView1.Items.Add(item);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            try
            {
                danjishijian();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "来自系统提示");
            }
            finally
            {
                net.NETClose();
            }
        }

        private void danjishijian()
        {
            string sql = string.Format("select * from plane where Planeid = {0}", listView1.SelectedItems[0].SubItems[0].Text);
            IDataReader idr = net.Sdr(sql);
            if (idr.Read())
            {
                textBox1.Text = idr[1].ToString();
                textBox2.Text = idr[2].ToString();
                textBox3.Text = idr[3].ToString();
                textBox4.Text = idr[4].ToString();
                textBox5.Text = idr[5].ToString();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否要退出", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
