using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 图书信息管理系统
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        NET net = new NET();

        string sql = null;
        DataSet ds = new DataSet();
        IDataAdapter ida = null;
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                sql = string.Format("select * from Categories");
                ida = net.Sda(sql);
                ida.Fill(ds);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "CategoryName";
                comboBox1.ValueMember = "id";
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

        private void button1_Click(object sender, EventArgs e)
        {
            chaxun();
        }

        private void chaxun()
        {
            listView1.Items.Clear();
            sql = string.Format("select Title, Author, PublishDate, UnitPrice, CategoryName from Categories inner join Books on Categories.id = Books.Categoryid where Categories.id like '%{0}%'", comboBox1.SelectedValue);
            IDataReader idr = net.Sdr(sql);
            while (idr.Read())
            {
                ListViewItem item = new ListViewItem(idr[0].ToString());
                item.SubItems.Add(idr[1].ToString());
                item.SubItems.Add(idr[2].ToString());
                item.SubItems.Add(idr[3].ToString());
                listView1.Items.Add(item);
            }
            net.NETClose();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete  from Books where Title = '{0}' ", listView1.SelectedItems[0].SubItems[0].Text);
            IDbCommand idc = net.Com(sql);
            if (idc.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
            net.NETClose();
            chaxun();
        }
    }
}
