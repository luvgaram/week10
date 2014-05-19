using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUIRectangle
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                foreach (Shape shape in shapes)
                {
                    shape.Show(g);
                }
            }
        }

        private ArrayList shapes = new ArrayList();

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Random random = new Random();
            int type = random.Next(1, 5);
            int left = random.Next(1, 100);
            int top = random.Next(1, 100);
            int right = random.Next(200, 300);
            int bottom = random.Next(200, 300);
            Brush Color = Brushes.SkyBlue;

            Rectangle rectangle = new Rectangle(left, top, right, bottom);
            Square square = new Square(left, top, right, bottom);
            Ellipse ellipse = new Ellipse(left, top, right, bottom);
            Triangle triangle = new Triangle(left, top, right, bottom);

            switch (type)
            { 
                case 1:
                    shapes.Add(square);
                    break;
                case 2:
                    shapes.Add(rectangle);
                    break;
                case 3:
                    shapes.Add(ellipse);
                    break;
                case 4:
                    shapes.Add(triangle);
                    break;
             }
            Form1_Paint(null, null);
        }
    }
}
