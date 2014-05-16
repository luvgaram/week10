using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GUIRectangle
{
    

    class Rectangle
    {
        protected Point LeftTop;
        protected Point RightBottom;

        /*public Rectangle() : this(0, 0)
        {
        }

        public Rectangle(int Left, int Top) : this(Left, Top, Left + 100, Top + 100)
        {
        }*/

        public Rectangle(int Left, int Top, int Right, int Bottom)
        {
            this.LeftTop = new Point(Left, Top);
            this.RightBottom = new Point(Right, Bottom);
        }

        public virtual void Show(Graphics g)
        {
            g.FillRectangle(Brushes.SkyBlue,
                LeftTop.X, LeftTop.Y,
                RightBottom.X - LeftTop.X,
                RightBottom.Y - LeftTop.Y);

            g.DrawRectangle(Pens.Black,
                LeftTop.X, LeftTop.Y,
                RightBottom.X - LeftTop.X,
                RightBottom.Y - LeftTop.Y);

        }
     }

     class Square : Rectangle
     {
        private Brush Color;

        public Square(int Left, int Top, int Width, Brush Color) : base(Left, Top, Left + Width, Top + Width)
        {
            this.Color = Color;
        }

        public override void Show(Graphics g)
        {
            g.FillRectangle(Color,
                LeftTop.X, LeftTop.Y,
                RightBottom.X - LeftTop.X,
                RightBottom.Y - LeftTop.Y);

            g.DrawRectangle(Pens.Black,
                LeftTop.X, LeftTop.Y,
                RightBottom.X - LeftTop.X,
                RightBottom.Y - LeftTop.Y);
        }
     }

     class Triangle : Rectangle
     {
         private Brush Color;

         public Triangle(int Left, int Top, int Width, Brush Color)
             : base(Left, Top, Left + Width, Top + Width)
         {
             this.Color = Color;

         }

         public override void Show(Graphics g)
         {
             Point[] pts = new Point[] { new Point((LeftTop.X+RightBottom.Y)/2, LeftTop.X), new Point(LeftTop.X, RightBottom.Y), new Point(RightBottom.Y, RightBottom.X) };
             g.FillPolygon(Color, pts);
             g.DrawPolygon(Pens.Black, pts);
         }
     }

     class Ellipse : Rectangle
     {
         private Brush Color;

         public Ellipse(int Left, int Top, int Width, Brush Color)
             : base(Left, Top, Left + Width, Top + Width)
         {
             this.Color = Color;
         }

         public override void Show(Graphics g)
         {
             g.FillEllipse(Brushes.SkyBlue,
                 LeftTop.X, LeftTop.Y,
                 RightBottom.X - LeftTop.X,
                 RightBottom.Y - LeftTop.Y);

             g.DrawEllipse(Pens.Black,
                 LeftTop.X, LeftTop.Y,
                 RightBottom.X - LeftTop.X,
                 RightBottom.Y - LeftTop.Y);

         }
     }
}
