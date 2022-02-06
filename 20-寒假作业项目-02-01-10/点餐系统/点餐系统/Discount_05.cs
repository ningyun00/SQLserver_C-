using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 点餐系统
{
    public partial class Discount_05 : Form
    {
        public Discount_05()
        {
            InitializeComponent();
        }
        NET net = new NET();
        //创建对象
        string sql = null;
        double zheKo;

        /// <summary>
        /// 加载菜品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Discount_05_Load(object sender, EventArgs e)
        {
            for (double i = 0.9; i >= 0.1; i -= 0.1)
            {
                sql = i.ToString().Substring(0, 3);
                zheKo = Convert.ToDouble(sql);
                comboBox1.Items.Add(zheKo);
            }
            comboBox1.SelectedIndex = 0;
            zheKoShangPin();
        }

        private void 折扣ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows[0].Cells[1].Value != null)
                {
                    sql = string.Format("select * from EverySingle02 where Vegetables ='{0}'", dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                    IDataReader idr = net.Sdr(sql);
                    while (idr.Read())
                    {
                        label3.Text = idr["Vegetables"].ToString();
                        label5.Text = idr["OriginalCost"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("请选择菜品", "系统提示");
                }
            }
            catch (Exception ErrorPrompt)
            {//错误提示
                MessageBox.Show(ErrorPrompt.Message, "来自系统提示");
            }
        }

        private void 备注ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows[0].Cells[1].Value != null)
                {
                    sql = string.Format("select * from EverySingle02 where Vegetables ='{0}'", dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                    IDataReader idr = net.Sdr(sql);
                    while (idr.Read())
                    {
                        label11.Text = idr["Vegetables"].ToString();
                        textBox1.Text = idr["Remark"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("请选择菜品", "系统提示");
                }
            }
            catch (Exception ErrorPrompt)
            {//错误提示
                MessageBox.Show(ErrorPrompt.Message, "来自系统提示");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label5.Name != label5.Text)
            {
                label8.Text = (Convert.ToDouble(comboBox1.Text) * Convert.ToDouble(label5.Text)).ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要修改吗?", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = string.Format("update EverySingle02 set Discount ={0} where Vegetables = '{1}'", label8.Text, label3.Text);
                if (net.Execute(sql) > 0)
                {
                    MessageBox.Show("修改折扣成功", "系统提示");
                }
                else
                {
                    MessageBox.Show("修改折扣失败", "系统提示");
                }
                zheKoShangPin();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要修改吗?", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = string.Format("update EverySingle02 set Remark ='{0}' where Vegetables = '{1}'", textBox1.Text, label11.Text);
                if (net.Execute(sql) > 0)
                {
                    MessageBox.Show("备注添加成功", "系统提示");
                }
                else
                {
                    MessageBox.Show("备注添加失败", "系统提示");
                }
                zheKoShangPin();
            }
        }

        private void zheKoShangPin()
        {
            try
            {
                sql = string.Format("select * from EverySingle02");
                IDataAdapter ida = net.Sda(sql);
                DataSet ds = new DataSet();
                ida.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                net.NETClose();
            }
            catch (Exception ErrorPrompt)
            {//错误提示
                MessageBox.Show(ErrorPrompt.Message, "来自系统提示");
            }
        }

        private void Discount_05_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainInterface_01 mainInterface = new mainInterface_01();
            mainInterface.LoadClass();
            if (MessageBox.Show("是否退出修改", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vegetable_06 vegetable = new Vegetable_06();
            vegetable.ShowDialog();
        }
    }
}
