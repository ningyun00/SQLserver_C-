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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "1000万";
            if (cboCity.Text.Equals("长沙"))
            {
                label1.Text = "300万";
            }
            if (cboCity.Text.Equals("上海"))
            {
                label1.Text = "1000万";
            }
            if (cboCity.Text.Equals("北京"))
            {
                label1.Text = "1200万";
            }
            if (cboCity.Text.Equals("南京"))
            {
                label1.Text = "500万";
            }
        }
    }
}
