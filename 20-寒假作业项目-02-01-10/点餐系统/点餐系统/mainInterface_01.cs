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
    public partial class mainInterface_01 : Form
    {
        public mainInterface_01()
        {
            InitializeComponent();
        }
        NET net = new NET();
        //创建对象
        int maxTable = 30;
        //三十个座位
        public static int nunber = 0;
        //传值点击的哪一个桌子
        public static string startDateTime;
        //点餐开始时间
        OrderInterface_02 orderInterface = new OrderInterface_02();
        //实例化窗体
        string sql = null;
        public static int bianhao;
        public static int bianhao1;
        public static int xulh;


        /// <summary>
        /// 计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {//计时器
            try
            {//异常处理
                DateTime dTime = DateTime.Now;
                toolStripStatusLabel2.Text = dTime.ToString("G");
            }
            catch (Exception ErrorPrompt)
            {//错误提示
                MessageBox.Show(ErrorPrompt.Message, "来自系统提示");
            }
        }

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainInterface_01_Load(object sender, EventArgs e)
        {//加载事件
            try
            {//异常处理
                LoadClass();
            }
            catch (Exception ErrorPrompt)
            {//错误提示
                MessageBox.Show(ErrorPrompt.Message, "来自系统提示");
            }
        }

        public void LoadClass()
        {
            Button button = new Button();
            button.BackColor = Color.White;
            timer1.Start();
            //计时器开启
            toolStripStatusLabel4.Text = maxTable.ToString();
            //桌位总数
            toolStripStatusLabel12.Text = Register_00.name;
            //用户名
            toolStripStatusLabel12.ForeColor = Color.Red;
            //用户名颜色
            if (Register_00.start == "普通员")
            {
                toolStripStatusLabel10.Text = Register_00.start;
                toolStripStatusLabel13.Visible = false;
                button31.Visible = false;
                button32.Visible = false;
                button33.Visible = false;
            }
            else if (Register_00.start == "管理员")
            {
                toolStripStatusLabel10.Text = Register_00.start;
            }
            //显示管理权限
            sql = string.Format("select * from OrderList05");
            IDataReader idr = net.Sdr(sql);
            if (idr.Read())
            {
                bianhao = Convert.ToInt32(idr["OrderListNO"]);
            }
            net.NETClose();
            sql = string.Format("select TableNumber from Table01;");
            idr = net.Sdr(sql);
            if (idr.Read())
            {
                xulh = Convert.ToInt32(idr["TableNumber"]);
            }
            net.NETClose();
            #region 桌位空桌显示
            Button[] buttons = new Button[30];
            //alterInterface.ShowDialog();
            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;
            buttons[9] = button10;
            buttons[10] = button11;
            buttons[11] = button12;
            buttons[12] = button13;
            buttons[13] = button14;
            buttons[14] = button15;
            buttons[15] = button16;
            buttons[16] = button17;
            buttons[17] = button18;
            buttons[18] = button19;
            buttons[19] = button20;
            buttons[20] = button21;
            buttons[21] = button22;
            buttons[22] = button23;
            buttons[23] = button24;
            buttons[24] = button25;
            buttons[25] = button26;
            buttons[26] = button27;
            buttons[27] = button28;
            buttons[28] = button29;
            buttons[29] = button30;
            for (int i = 0; i < 30; i++)
            {
                sql = string.Format("select * from Table01 where TableType = '有'");
                idr = net.Sdr(sql);
                int A = 0;
                int B = 30;
                while (idr.Read())
                {
                    A = A + 1;
                    bianhao = Convert.ToInt32(idr["TableNumber"]);
                    if (Convert.ToInt32(buttons[i].Text) == bianhao)
                    {
                        buttons[i].BackColor = Color.Red;
                        toolStripStatusLabel6.Text = A.ToString();
                        toolStripStatusLabel8.Text = (B - A).ToString();
                    }
                }
                toolStripStatusLabel6.Text = A.ToString();
                toolStripStatusLabel8.Text = (B - A).ToString();
            }
            #endregion
            #region 折扣菜显示
            listView1.Items.Clear();
            sql = string.Format("select * from EverySingle02 where OriginalCost != Discount");
            idr = net.Sdr(sql);
            while (idr.Read())
            {
                ListViewItem item = new ListViewItem(idr["NO"].ToString());
                item.SubItems.Add(idr["Vegetables"].ToString());
                item.SubItems.Add(idr["OriginalCost"].ToString());
                item.SubItems.Add(idr["Discount"].ToString());
                listView1.Items.Add(item);
            }
            #endregion

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {//异常处理
                Button button = (Button)sender;
                //关联按钮
                nunber = Convert.ToInt32(button.Text);
                //每一个按钮上的数值
                if (nunber <= 30 && nunber > 0)
                {//判断范围是否有空位
                    startDateTime = toolStripStatusLabel2.Text;
                    bianhao++;
                    orderInterface.ShowDialog();
                }
                else
                {
                    MessageBox.Show("桌位已满", "系统提示");
                }
            }
            catch (Exception ErrorPrompt)
            {//错误提示
                MessageBox.Show(ErrorPrompt.Message, "来自系统提示");
            }
        }
        /// <summary>
        /// 修改菜品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button31_Click(object sender, EventArgs e)
        {
            LoadClass();
            Discount_05 discount = new Discount_05();
            discount.ShowDialog();
        }
        /// <summary>
        /// 关闭系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainInterface_01_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("要退出程序吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Vegetable_06 vegetable = new Vegetable_06();
            vegetable.ShowDialog();

        }

        private void button33_Click(object sender, EventArgs e)
        {
            Register_00.start = "管理员";
            Login_07 login = new Login_07();
            login.ShowDialog();
        }

        private void toolStripStatusLabel13_Click(object sender, EventArgs e)
        {
            Add_04 add = new Add_04();
            add.ShowDialog();
        }

        private void toolStripStatusLabel14_Click(object sender, EventArgs e)
        {
            LoadClass();
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadClass();
        }
    }
}
