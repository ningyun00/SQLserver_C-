using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 测试.Properties;

namespace 测试
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }
        //窗体第一次绘制加载
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = this.CreateGraphics();//将窗体当作画布
            #region 怎么绘制线和字符串
            /* Pen pen = new Pen(Color.Black);//创建画笔             
             graphics.DrawLine(pen, new Point(50, 50), new Point(100, 100));//画线坐标50~=1cm
            graphics.DrawString("寜-小樱",
            new Font("宋体", 20),
                new SolidBrush(Color.Red),
                new Point(100, 100));*/
            //图片引用
            #endregion
            Pen pen = new Pen(Color.Red);
            Pen pen1 = new Pen(Color.Pink);
            graphics.DrawLine(pen, new Point(0, 0), new Point(100, 100));
            graphics.DrawLine(pen, new Point(1, 0), new Point(0, 1));
            graphics.DrawLine(pen, new Point(0, 150), new Point(100, 100));
            graphics.DrawLine(pen, new Point(0, 150), new Point(200, 200));
            graphics.DrawLine(pen, new Point(0, 200), new Point(250, 250));
            graphics.DrawLine(pen, new Point(150, 200), new Point(0, 150));

            Image image = Properties.Resources.Boss;
            Bitmap bitmap = Properties.Resources.Star1;
            /*bitmap.MakeTransparent(Color.Black);//将黑色变成透明            
               graphics.DrawImage(bitmap, 150, 150);
               graphics.DrawImage(image, 200, 200);*/

        }
    }
}
