using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace 点餐系统
{
    public partial class Add_04 : Form
    {
        public Add_04()
        {
            InitializeComponent();
        }

        NET net = new NET();

        string sql = null;

        private void button1_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into EverySingle02 values('{0}',{1},{2},{3},'{4}')", textBox1.Text.Trim(), comboBox1.SelectedValue, textBox2.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim());
            if (net.Execute(sql) > 0)
            {
                MessageBox.Show("添加成功", "系统提示");
            }
            else
            {
                MessageBox.Show("添加失败", "系统提示");
            }
            net.NETClose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into VegetableDishes03 values('{0}','{1}')", textBox5.Text.Trim(), textBox6.Text.Trim());
            if (net.Execute(sql) > 0)
            {
                MessageBox.Show("添加成功", "系统提示");
                Loadclass();
            }
            else
            {
                MessageBox.Show("添加失败", "系统提示");
            }
            net.NETClose();
        }

        private void Add_04_Load(object sender, EventArgs e)
        {
            Loadclass();
        }

        private void Loadclass()
        {
            sql = string.Format("select * from VegetableDishes03");
            IDataAdapter ida = net.Sda(sql);
            DataSet ds = new DataSet();
            ida.Fill(ds);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.ValueMember = "NO";
            comboBox1.DisplayMember = "DishesType";
            net.NETClose();
        }
    }
}
