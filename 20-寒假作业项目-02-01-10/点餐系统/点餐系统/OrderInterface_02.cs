using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace 点餐系统
{
    public partial class OrderInterface_02 : Form
    {
        public OrderInterface_02()
        {
            InitializeComponent();
        }

        string sql = null;
        //声明字符串
        NET net = new NET();
        //创建对象
        public static double maney;
        //单价
        public static double sumManey;
        //总价
        public static double people = 4;
        //每人10元
        public static double maney1;
        //验算价格

        #region 参数
        public int type = 0;
        double sum;
        double sum1;
        public static string caipin = null;
        public static string jiagejeiqu;
        #endregion

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderInterface_02_Load(object sender, EventArgs e)
        {//加载事件
            try
            {//异常处理
                label2.Text = mainInterface_01.nunber.ToString();
                //显示桌号
                LoadVegetables();
                //加载菜品
                timer1.Start();
                //开启计时器
                label16.Text = mainInterface_01.bianhao.ToString();
                //订单编号
                comboBox1.Items.Clear();
                //清空下拉框
                for (int i = 1; i <= 8; i++)
                {
                    comboBox1.Items.Add(i);
                }
                comboBox1.SelectedIndex = 0;
                //人数默认为一人
                listView1.Items.Clear();
                //清除订单
                label7.Text = "4";
                label11.Text = "0";
                textBox1.Text = "0";
                //清空价格
                label14.Text = people.ToString();
                //默认一人10元
                maney = 0;
                //价格清空
                sumManey = 0;
                listView1.HideSelection = false;
            }
            catch (Exception ErrorPrompt)
            {//错误提示
                MessageBox.Show(ErrorPrompt.Message, "来自系统提示");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            label5.Text = dateTime.ToString("G");
        }

        /// <summary>
        /// 加入订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {
                    ListViewItem item = new ListViewItem(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    item.SubItems.Add(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                    item.SubItems.Add(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                    maney += Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[4].Value);
                    //一次计算
                    maney1 = maney;
                    label7.Text = maney.ToString();
                    listView1.Items.Add(item);
                    type++;
                    label18.Text = type.ToString();
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

        /// <summary>
        /// 清除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要清除吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                listView1.Items.Clear();
                //清空订单
                label7.Text = "4";
                label11.Text = "0";
                textBox1.Text = "0";
                maney = 0;
                sumManey = 0;
                sum = 0;
                sum1 = 0;
                //清空价格
            }
        }
        /// <summary>
        ///  删除订单中的一条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                maney -= Convert.ToDouble(listView1.Items[listView1.SelectedItems[0].Index].SubItems[2].Text);
                //拿取单价
                maney1 = maney;
                //二次计算
                label7.Text = maney.ToString();
                listView1.Items.RemoveAt(Convert.ToInt32(listView1.SelectedItems[0].Index));
                type--;
                label18.Text = type.ToString();
            }
            else
            {
                MessageBox.Show("请选择要删除的菜品", "系统提示");
            }
        }
        /// <summary>
        /// 计算价格并得出找零
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (maney < Convert.ToDouble(textBox1.Text))
                {
                    sum = Convert.ToDouble(textBox1.Text);
                    sum1 = Convert.ToDouble(label7.Text);
                    jiagejeiqu = (sum - sum1).ToString();
                    label11.Text = jiagejeiqu.Substring(0, 4);
                }
                else
                {
                    MessageBox.Show("支付金额输入错误", "系统提示");
                }
            }
            else
            {
                MessageBox.Show("请输入支付金额", "系统提示");
            }
        }
        /// <summary>
        /// 人数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            label14.Text = (Convert.ToInt32(comboBox1.Text) * people).ToString();
            maney += Convert.ToDouble(label14.Text);
            label7.Text = maney.ToString();
        }
        /// <summary>
        /// 结算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                sql = string.Format("update Table01 set TableType = '有' where TableNumber = {0}", label2.Text);
                if (net.Execute(sql) > 0)
                {//添加成功
                 //桌位有人
                }
                else
                {
                    MessageBox.Show("订单添加失败", "系统提示");
                }
                net.NETClose();

                caipin = string.Empty;
                for (int i = 0; i <= Convert.ToInt32(label18.Text) - 1; i++)
                {
                    listView1.Items[i].Selected = true;
                    caipin += listView1.Items[listView1.SelectedItems[i].Index].SubItems[1].Text + "。";
                }
                sql = string.Format("update OrderList05  set OrderListNO = {0} ", label16.Text);
                if (net.Execute(sql) > 0)
                {//添加成功
                 //订单编号
                }
                else
                {
                    MessageBox.Show("订单添加失败", "系统提示");
                }
                net.NETClose();
                sql = string.Format("insert into OrderTable04 values({0}, {1}, '{2}', '{3}', '{4}', {5},{6},{7},'{8}')", label2.Text, label16.Text, mainInterface_01.startDateTime, label5.Text, caipin, label7.Text, textBox1.Text, label11.Text, null);
                if (net.Execute(sql) > 0)
                {
                    if (MessageBox.Show("要打印订单吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {//打印订单
                        MessageBox.Show(caipin + "\n共" + label18.Text + "份\n" + "一共" + label11.Text + "元\n", "系统提示");
                    }
                }
                else
                {
                    MessageBox.Show("订单添加失败", "系统提示");
                }
                net.NETClose();
            }
            catch (Exception ErrorPrompt)
            {//错误提示
                MessageBox.Show(ErrorPrompt.Message, "来自系统提示");
            }
        }
        /// <summary>
        /// 关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderInterface_02_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定要取消点餐吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Hide();
            }
            else
            {
                e.Cancel = true;
            }
        }

        #region 方法
        /// <summary>
        /// 加载菜品方法
        /// </summary>
        private void LoadVegetables()
        {
            try
            {//异常处理
                sql = string.Format("select EverySingle02.NO,Vegetables,VegetableDishes03.DishesType,OriginalCost,Discount,EverySingle02.Remark from EverySingle02 inner join VegetableDishes03 on EverySingle02.DishesType=VegetableDishes03.NO");
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
        #endregion
    }
}

