﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GUIRectangle
{

    class Shape
    {
        protected Point LeftTop;
        protected Point RightBottom;

        public Shape(int Left, int Top, int Right, int Bottom)
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

    class Rectangle : Shape
    {
        public Rectangle(int Left, int Top, int Right, int Bottom)
            : base(Left, Top, Right, Bottom)
        {
            this.LeftTop = new Point(Left, Top);
            this.RightBottom = new Point(Right, Bottom);
        }

        public override void Show(Graphics g)
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

    class Square : Shape
    {
        public Square(int Left, int Top, int Right, int Bottom)
            : base(Left, Top, Right, Bottom)
        {
            this.LeftTop = new Point(Left, Top);
            this.RightBottom = new Point(Right, Top + (Right - Left));
        }

        public override void Show(Graphics g)
        {
            g.FillRectangle(Brushes.Red,
                LeftTop.X, LeftTop.Y,
                RightBottom.X - LeftTop.X,
                RightBottom.Y - LeftTop.Y);

            g.DrawRectangle(Pens.Black,
                LeftTop.X, LeftTop.Y,
                RightBottom.X - LeftTop.X,
                RightBottom.Y - LeftTop.Y);
        }
    }

    class Triangle : Shape
    {
        public Triangle(int Left, int Top, int Right, int Bottom)
            : base(Left, Top, Right, Bottom)
        {
            this.LeftTop = new Point(Left, Top);
            this.RightBottom = new Point(Right, Bottom);
        }

        public override void Show(Graphics g)
        {
            Point[] pts = new Point[] { new Point((LeftTop.X + RightBottom.Y) / 2, LeftTop.X), new Point(LeftTop.X, RightBottom.Y), new Point(RightBottom.Y, RightBottom.X) };
            g.FillPolygon(Brushes.Yellow, pts);
            g.DrawPolygon(Pens.Black, pts);
        }
    }

    class Ellipse : Shape
    {
        public Ellipse(int Left, int Top, int Right, int Bottom)
            : base(Left, Top, Right, Bottom)
        {
        }

        public override void Show(Graphics g)
        {
            g.FillEllipse(Brushes.Pink,
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
