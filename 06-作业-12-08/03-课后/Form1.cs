using System;
using System.Windows.Forms;

namespace _03_课后
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void comboBox2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请输入年份", "错误");
            }
        }
        private void comboBox1_Click(object sender, EventArgs e)
        {//单击事件
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请输入年份", "错误");
            }
            else
            {
                comboBox1.Items.Clear();//清除全部日期
                comboBox2.Items.Clear();//清除全部日期
                for (int i = 1; i <= 12; i++)
                {
                    comboBox1.Items.Add(i + "月");//添加月
                }
                comboBox1.SelectedIndex = 1;//默认2月
                switch (comboBox1.Text)//判断默认月份显示日
                {
                    case "1月":
                    case "3月":
                    case "5月":
                    case "7月":
                    case "8月":
                    case "10月":
                    case "12月":
                        for (int i = 1; i <= 31; i++)
                        {
                            comboBox2.Items.Add(i + "日");
                        }
                        break;
                    case "4月":
                    case "6月":
                    case "9月":
                    case "11月":
                        for (int i = 1; i <= 30; i++)
                        {
                            comboBox2.Items.Add(i + "日");
                        }
                        break;
                    case "2月"://判断年份
                        comboBox2.Items.Clear();//清初多余日期
                        if (Convert.ToInt32(textBox1.Text) % 4 == 0 && Convert.ToInt32(textBox1.Text) % 100 != 0 || Convert.ToInt32(textBox1.Text) % 400 == 0)
                        {//闰年
                            for (int i = 1; i <= 29; i++)
                            {
                                comboBox2.Items.Add(i + "日");
                            }
                            comboBox2.SelectedIndex = 28;//默认二月29天--29日
                        }
                        else
                        {//平年
                            for (int i = 1; i <= 28; i++)
                            {
                                comboBox2.Items.Add(i + "日");
                            }
                            comboBox2.SelectedIndex = 27;//默认二月28天--28日
                        }
                        break;
                    default://其它出现未知错误
                        DialogResult dialogResult = MessageBox.Show("错误", "错误", MessageBoxButtons.RetryCancel);
                        if (dialogResult == DialogResult.Retry)
                        {
                            Show();
                        }
                        else
                        {
                            Application.Exit();
                        }
                        break;
                }
            }
            {
                /*            if (comboBox1.Text.Equals("1月")|| comboBox1.Text.Equals("3月") || comboBox1.Text.Equals("5月") || comboBox1.Text.Equals("7月") || comboBox1.Text.Equals("8月") || comboBox1.Text.Equals("10月") || comboBox1.Text.Equals("12月"))
                            {
                                for (int i = 1; i <= 31; i++)
                                {
                                    comboBox2.Items.Add(i + "日");
                                }
                            }
                            else if (comboBox1.Text.Equals("4月") || comboBox1.Text.Equals("6月") || comboBox1.Text.Equals("9月") || comboBox1.Text.Equals("11月"))
                            {
                                for (int i = 1; i <= 30; i++)
                                {
                                    comboBox2.Items.Add(i + "日");
                                }
                            }
                            else
                            {
                                if (Convert.ToInt32(textBox1.Text) % 4 == 0 && Convert.ToInt32(textBox1.Text) % 100 != 0 || Convert.ToInt32(textBox1.Text) % 400 == 0)
                                {
                                    for (int i = 1; i <= 29; i++)
                                    {
                                        comboBox2.Items.Add(i + "日");
                                    }
                                }
                                else
                                {
                                    for (int i = 1; i <= 28; i++)
                                    {
                                        comboBox2.Items.Add(i + "日");
                                    }
                                }
                            }
                            comboBox2.SelectedIndex = 0;*/
            }//方法二
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//点击月份相应
            comboBox2.Items.Clear();//清除多余日
            switch (comboBox1.Text)//判断月份得到日
            {
                case "1月":
                case "3月":
                case "5月":
                case "7月":
                case "8月":
                case "10月":
                case "12月":
                    for (int i = 1; i <= 31; i++)
                    {
                        comboBox2.Items.Add(i + "日");
                    }
                    break;
                case "4月":
                case "6月":
                case "9月":
                case "11月":
                    for (int i = 1; i <= 30; i++)
                    {
                        comboBox2.Items.Add(i + "日");
                    }
                    break;
                case "2月":
                    comboBox2.Items.Clear();
                    if (Convert.ToInt32(textBox1.Text) % 4 == 0 && Convert.ToInt32(textBox1.Text) % 100 != 0 || Convert.ToInt32(textBox1.Text) % 400 == 0)
                    {//闰年
                        for (int i = 1; i <= 29; i++)
                        {
                            comboBox2.Items.Add(i + "日");
                        }
                    }
                    else
                    {//平年
                        for (int i = 1; i <= 28; i++)
                        {
                            comboBox2.Items.Add(i + "日");
                        }
                    }
                    break;
                default://错误
                    DialogResult dialogResult = MessageBox.Show("错误", "错误", MessageBoxButtons.RetryCancel);
                    if (dialogResult == DialogResult.Retry)
                    {
                        Show();
                    }
                    else
                    {
                        Application.Exit();
                    }
                    break;
            }
            comboBox2.SelectedIndex = 0;//默认日 - 1
        }
        private void button1_Click(object sender, EventArgs e)
        {//确定事件
            if (textBox1.Text == string.Empty)
            {//为空
                DialogResult dialogResult = MessageBox.Show("请填入你的生日", "错误", MessageBoxButtons.RetryCancel);
                if (dialogResult == DialogResult.Retry)
                {
                    Show();//再次显示窗体，否则会结束
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {//不为空
                MessageBox.Show("你的生日是：" + textBox1.Text + "年" + comboBox1.Text + comboBox2.Text, "生日", MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

