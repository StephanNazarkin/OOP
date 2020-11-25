using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_4
{

    public class Circle : CPoint
    {
        public Pen Pen
        {
            get { return pen; }
            set { pen = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Perimeter
        {
            get { return perimeter; }
            set { perimeter = calculateP(); }
        }

        public Circle()
        {
            
        }

        public Circle(Pen penC, int xC, int yC, int widthC, int heightC)
        {
            pen = penC;
            x = xC;
            y = yC;
            width = widthC;
            height = heightC;
        }

        ~Circle()
        {
            
        }

        public double calculateP()
        {
            double p = 2 * Math.PI * (width / 2);
            return p;
        }
        public static double operator *(Circle c, Octagon oct)
        {
            double p = oct.calculateP() * c.calculateP();
            return p;
        }

        public override void show(PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(pen, x, y, width, height);
        }
    }
}