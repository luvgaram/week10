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
        
        private Rectangle[] rectangles = new Rectangle[]
        {
            new Rectangle(10,10,100,100),
            new Square(30,30,70, Brushes.Blue),
            new Rectangle(30,30,120,120),
            new Square(100,100,20, Brushes.Pink)
        };
         

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                foreach (Rectangle rectangle in rectangles)
                {
                    rectangle.Show(g);
                }
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Random random = new Random();
            int left = random.Next(1, 100);
            int top = random.Next(1, 100);
            int right = random.Next(200, 300);
            int bottom = random.Next(200, 300);

            Rectangle rectangle = new Rectangle(left, top, right, bottom);

            Rectangle[] newRectangles = new Rectangle[rectangles.Length + 1];
            Array.Copy(rectangles, newRectangles, 1); // 첫번째 자리에 rectangles의 주소 복사

            newRectangles[1] = rectangle; // 두번째 자리에 새 rectangle 값 넣음
            Array.Copy(rectangles, 1, newRectangles, 2, rectangles.Length - 1); // rectangles의 1부터 길이-1 까지의 값을 복사해서 2부터 나머지 rectangles의 주소 복사

            rectangles = newRectangles; // rectangles가 새 배열을 가르키도록 함 

            Form1_Paint(null, null);
        }
    }
}

