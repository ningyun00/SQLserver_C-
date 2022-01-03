using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _03_附加题
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SizeConter();
        }
        #region 窗体字体居中
        private void SizeConter()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            Graphics g = this.CreateGraphics();
            Double startingPoint = (this.Width / 2) - (g.MeasureString(this.Text.Trim(), this.Font).Width / 2);
            Double ws = g.MeasureString("*", this.Font).Width;
            String tmp = " ";
            Double tw = 0;

            while ((tw + ws) < startingPoint)
            {
                tmp += "3 ";
                tw += ws;
            }
            this.Text = tmp.Replace("3", " ") + this.Text.Trim();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Diagnostics.Process.Start(@"D:\0-6-Eclicp\\eclipse.exe");
            Application.Exit();
        }
    }
}
