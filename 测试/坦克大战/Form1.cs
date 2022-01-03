using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace 坦克大战
{
    public partial class Form1 : Form
    {
        private Thread t;
        private Graphics g;
        private static Bitmap tempBmp;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            tempBmp = new Bitmap(450, 450);
            Graphics bmpG = Graphics.FromImage(tempBmp);
            GameFramework.g = bmpG;
            //阻塞
            Thread thread = new Thread(new ThreadStart(GameMainThread));
            thread.Start();

            //画布
            Graphics g = CreateGraphics();
            GameFramework.g = g;//赋格给
        }
        private static void GameMainThread()
        {
            //管理游戏框架类--GameFmework
            GameFramework.Start();//一直调用
            int sleepTime = 1000 / 60;//定义

            //FPS~=60
            while (true)
            {
                GameFramework.g.Clear(Color.Black);//清空画布,变成黑色

                GameFramework.Update();//~=60

                //每次调用完休息1/60秒
                Thread.Sleep(sleepTime);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            t.Abort();
        }
    }
}
