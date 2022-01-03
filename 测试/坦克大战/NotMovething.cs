using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace 坦克大战
{
    /***
     * 不可移动的物体
     */
    class NotMovething : GameObjcet
    {
        public Image Img { get; set; }

        protected override Image GetImage()
        {
            return Img;
        }
        public NotMovething(int x, int y, Image img)
        {
            X = x;
            Y = y;
            Img = img;
        }
    }
}
