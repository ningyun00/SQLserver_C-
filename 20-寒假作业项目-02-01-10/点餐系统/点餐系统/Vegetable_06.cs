using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 点餐系统
{
    public partial class Vegetable_06 : Form
    {
        public Vegetable_06()
        {
            InitializeComponent();
        }
        NET net = new NET();
        string sql = null;
        mainInterface_01 mainInterface = new mainInterface_01();
        private void Vegetable_06_Load(object sender, EventArgs e)
        {
            try
            {
                sql = string.Format("select * from OrderTable04");
                IDataAdapter ida = net.Sda(sql);
                DataSet ds = new DataSet();
                ida.Fill(ds);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "NO";
                comboBox1.ValueMember = "OrderNumber";
            }
            catch (Exception ErrorPrompt)
            {//错误提示
                MessageBox.Show(ErrorPrompt.Message, "来自系统提示");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = $"select NO,TableNumber,OrderNumber,Vegetables from OrderTable04 where OrderNumber = {comboBox1.SelectedValue}";
            IDataAdapter ida = net.Sda(sql);
            DataSet ds = new DataSet();
            ida.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
