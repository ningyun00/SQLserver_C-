using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _01_上机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SetSelected(0, true);//加载事件加载第一条被选中
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我的最爱" + listBox1.SelectedItem.ToString(), "提示");//输出
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();//获取焦点
            if (textBox1.Text == string.Empty)//不能为空
            {
                MessageBox.Show("不能为空,请输入姓名","错误");
            }
            else if (listBox1.FindString(textBox1.Text) != ListBox.NoMatches)//判断是否重复输入
            {
                listBox1.Items.Insert(0, textBox1.Text);//添加第一行
                listBox1.Items.RemoveAt(0);//删除第一行
                listBox1.SetSelected(listBox1.FindString(textBox1.Text), true);//将焦点给相同的内容
                if (listBox1.SelectedItem.ToString().Length==textBox1.Text.Length)//当listbox1的长度等于textbox1的长度 相同输出if不同输出else
                {
                    MessageBox.Show("存在相同内容：" + listBox1.SelectedItem.ToString(), "错误");//输出相同的内容
                }
                else
                {
                    listBox1.Items.Insert(0, textBox1.Text);//不同添加至第一行
                }                
            }
            else
            {
                listBox1.Items.Insert(0, textBox1.Text);//填入第一行
            }
            textBox1.Clear();//清除文本
        }
        private void button3_Click(object sender, EventArgs e)//循环下一个
        {
            int index = this.listBox1.SelectedIndex;//取到第一个下标--0
            index++;//1++;
            if (index >= this.listBox1.Items.Count)//1++>=最后一个时
            {
                index = 0;//跳回第一个
            }
            listBox1.SetSelected(index, true);//将光标跳至下标处
        }
    }
}
