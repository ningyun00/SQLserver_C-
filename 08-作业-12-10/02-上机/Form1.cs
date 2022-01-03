using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _02_上机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string annui = "";//按钮上的数字
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;//按钮方法
            annui = annui + button.Text;//拼接
            textBox1.Text = annui;//填回去
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);//从零开始每次截取总长度减一
        }
    }
}
