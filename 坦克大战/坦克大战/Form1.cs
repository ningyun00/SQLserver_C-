using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 坦克大战
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int A = e.KeyValue;
            char CHAR = (char)A;
            if (CHAR == 'W' || CHAR == 'w')
            {
                pictureBox1.Image = Image.FromFile("图片\\w.png");
                pictureBox1.Top -= 1;// 上

            }
            if (CHAR == 'S' || CHAR == 's')
            {
                pictureBox1.Image = Image.FromFile("图片\\s.png");
                pictureBox1.Top += 1;//下
            }
            if (CHAR == 'A' || CHAR == 'a')
            {
                pictureBox1.Image = Image.FromFile("图片\\a.png");
                pictureBox1.Left -= 1;//左
            }
            if (CHAR == 'D' || CHAR == 'd')
            {
                pictureBox1.Image = Image.FromFile("图片\\d.png");
                pictureBox1.Left += 1;//右
            }
            if (CHAR == 'L' || CHAR == 'l')
            {
                timer2.Start();
                pictureBox3.Image = Image.FromFile("图片\\l.png");
            }
            //范围外边距
            {
                //左边距
                if (pictureBox1.Location.X == 0)//左边距
                {
                    pictureBox1.Left += 2;//反向增加,右增
                }
                //右边距
                if (pictureBox1.Location.X == 403)//右边距
                {
                    pictureBox1.Left -= 2;//左增
                }
                //上边距
                if (pictureBox1.Location.Y == 0)//上边距
                {
                    pictureBox1.Top += 2;//下增
                }
                //下边距
                if (pictureBox1.Location.Y == 403)//下边距
                {
                    pictureBox1.Top -= 2;//上增
                }
            }
            //墙一
            if (pictureBox1.Location.X >= 5 && pictureBox1.Location.X <= 62 && pictureBox1.Location.Y >= 4 && pictureBox1.Location.Y <= 183)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 62)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 5)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 183)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 4)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            }
            //墙二
            if (pictureBox1.Location.X >= 70 && pictureBox1.Location.X <= 130 && pictureBox1.Location.Y >= 4 && pictureBox1.Location.Y <= 183)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 70)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 130)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 183)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 4)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            }
            //墙三
            if (pictureBox1.Location.X >= 137 && pictureBox1.Location.X <= 200 && pictureBox1.Location.Y >= 4 && pictureBox1.Location.Y <= 148)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 137)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 200)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 148)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 4)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            }
            //墙四
            if (pictureBox1.Location.X >= 200 && pictureBox1.Location.X <= 236 && pictureBox1.Location.Y >= 70 && pictureBox1.Location.Y <= 135)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 202)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 236)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 135)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 70)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            } 
            //墙五
            if (pictureBox1.Location.X >= 205 && pictureBox1.Location.X <= 265 && pictureBox1.Location.Y >= 4 && pictureBox1.Location.Y <= 148)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 205)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 265)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 2)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 148)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            } 
            //墙六
            if (pictureBox1.Location.X >= 272 && pictureBox1.Location.X <= 335 && pictureBox1.Location.Y >= 4 && pictureBox1.Location.Y <= 183)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 272)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 335)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 4)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 182)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            }
            //墙七
            if (pictureBox1.Location.X >= 340 && pictureBox1.Location.X <= 400 && pictureBox1.Location.Y >= 4 && pictureBox1.Location.Y <= 183)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 340)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 400)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 4)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 182)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            }
            //墙八
            if (pictureBox1.Location.X >= 0 && pictureBox1.Location.X <= 31 && pictureBox1.Location.Y >= 190 && pictureBox1.Location.Y <= 251)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 0)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 31)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 190)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 251)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            }
            //墙九
            if (pictureBox1.Location.X >= 37 && pictureBox1.Location.X <= 133 && pictureBox1.Location.Y >= 189 && pictureBox1.Location.Y <= 251)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 37)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 133)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 189)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 251)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            }
            //墙10
            if (pictureBox1.Location.X >= 140 && pictureBox1.Location.X <= 196 && pictureBox1.Location.Y >= 156 && pictureBox1.Location.Y <= 214)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 140)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 196)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 156)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 214)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            }
            //墙11
            if (pictureBox1.Location.X >= 207 && pictureBox1.Location.X <= 267 && pictureBox1.Location.Y >= 156 && pictureBox1.Location.Y <= 214)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 207)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 267)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 156)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 214)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            }
            //墙12
            if (pictureBox1.Location.X >= 273 && pictureBox1.Location.X <= 367 && pictureBox1.Location.Y >= 189 && pictureBox1.Location.Y <= 251)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 273)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 367)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 189)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 251)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            }
            //墙13
            if (pictureBox1.Location.X >= 373 && pictureBox1.Location.X <= 402 && pictureBox1.Location.Y >= 190 && pictureBox1.Location.Y <= 251)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 373)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 402)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 190)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 251)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            }
            //墙14
            if (pictureBox1.Location.X >= 4 && pictureBox1.Location.X <= 62 && pictureBox1.Location.Y >= 258 && pictureBox1.Location.Y <= 400)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 4)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 62)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 258)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 400)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            }
            //墙15
            if (pictureBox1.Location.X >= 71 && pictureBox1.Location.X <= 132 && pictureBox1.Location.Y >= 258 && pictureBox1.Location.Y <= 400)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 71)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 132)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 258)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 400)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            }
            //墙16
            if (pictureBox1.Location.X >= 138 && pictureBox1.Location.X <= 199 && pictureBox1.Location.Y >= 224 && pictureBox1.Location.Y <= 349)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 138)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 199)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 224)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 349)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            }  
            //墙17
            if (pictureBox1.Location.X >= 199 && pictureBox1.Location.X <= 204 && pictureBox1.Location.Y >= 239 && pictureBox1.Location.Y <= 300)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 199)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 204)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 239)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 300)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            }
            //墙18
            if (pictureBox1.Location.X >= 205 && pictureBox1.Location.X <= 266 && pictureBox1.Location.Y >= 224 && pictureBox1.Location.Y <= 350)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 205)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 266)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 244)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 350)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            }
            //墙19
            if (pictureBox1.Location.X >= 273 && pictureBox1.Location.X <= 333 && pictureBox1.Location.Y >= 258 && pictureBox1.Location.Y <= 400)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 273)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 333)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 258)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 400)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            }
            //墙20
            if (pictureBox1.Location.X >= 339 && pictureBox1.Location.X <= 400 && pictureBox1.Location.Y >= 258 && pictureBox1.Location.Y <= 400)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 339)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 400)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 258)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 400)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            }
            //墙21
            if (pictureBox1.Location.X >= 156 && pictureBox1.Location.X <= 250 && pictureBox1.Location.Y >= 358 && pictureBox1.Location.Y <= 403)//左右上下
            {
                if ((CHAR == 'A' || CHAR == 'a') && pictureBox1.Location.X >= 156)//左墙
                {
                    pictureBox1.Left += 2;//左增
                }
                if ((CHAR == 'D' || CHAR == 'd') && pictureBox1.Location.X <= 250)//右墙
                {
                    pictureBox1.Left -= 2;//右增
                }
                if ((CHAR == 'W' || CHAR == 'w') && pictureBox1.Location.Y >= 358)//下墙
                {
                    pictureBox1.Top += 2;//下增
                }
                if ((CHAR == 'S' || CHAR == 's') && pictureBox1.Location.Y <= 403)//上墙
                {
                    pictureBox1.Top -= 2;//上增
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "X：" + pictureBox1.Location.X + "\nY：" + pictureBox1.Location.Y;
        }
        int i = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(166, 396 - i);//右
            i++;
        }
    }
}
