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
                jiazai();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "来自系统提示");
            }
        }

        private void jiazai()
        {
            listView1.Items.Clear();
            string sql = string.Format("select *  from plane");
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
            net.NETClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chaxun();
        }

        private void chaxun()
        {
            listView1.Items.Clear();
            string sql = string.Format("select *  from plane where LeaveCity = '{0}' and ArriveCity = '{1}'", textBox1.Text.Trim(), textBox2.Text.Trim());
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
            net.NETClose();
        }
    }
}
