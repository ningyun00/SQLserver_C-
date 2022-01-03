using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _03_上机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();//打开文件对话框
            openFileDialog.Multiselect = true;//打开多个文件
            DialogResult dialogResult = openFileDialog.ShowDialog();//弹出对话框
            if (dialogResult==DialogResult.OK)//判断是否点击确定
            {
                listBox1.Items.AddRange(openFileDialog.FileNames);//输出
            }
        }
    }
}
