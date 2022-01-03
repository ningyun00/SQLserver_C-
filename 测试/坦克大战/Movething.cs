using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace 坦克大战
{
    enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    class Movething : GameObjcet
    {
        public Bitmap BitmapUp { get; set; }//上
        public Bitmap BitmapDown { get; set; }//下
        public Bitmap BitmapLeft { get; set; }//左
        public Bitmap BitmapRight { get; set; }//右

        public int Speed { get; set; }
        public Direction Dir { get; set; }

        protected override Image GetImage()
        {
            Bitmap bitmap = null;
            switch (Dir)
            {
                case Direction.Up:
                    bitmap = BitmapUp;
                    break;
                case Direction.Down:
                    bitmap = BitmapDown;
                    break;
                case Direction.Left:
                    bitmap = BitmapLeft;
                    break;
                case Direction.Right:
                    bitmap = BitmapRight;
                    break;
            }
            bitmap.MakeTransparent(Color.Black);
            return bitmap;
        }
    }
}
