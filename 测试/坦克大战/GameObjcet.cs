using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace 坦克大战
{
    abstract class GameObjcet
    {
        //相当于public int x;
        public int X { get; set; }
        public int Y { get; set; }

        protected abstract Image GetImage();

        //画布
        public void DrewSelf()
        {
            Graphics g = GameFramework.g;

            g.DrawImage(GetImage(),X,Y);
        }
    }
}
