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
    public class Octagon : CPoint
    {
        public Point[] Points
        {
            get { return points; }
            set { points = value; }
        }

        public Pen Pen
        {
            get { return pen; }
            set { pen = value; }
        }

        public double Perimeter
        {
            get { return perimeter; }
            set { perimeter = calculateP(); }
        }


        public Octagon()
        {
            
        }

        public Octagon(Pen penOct, Point[] p)
        {
            pen = penOct;
            points = p;
        }

        ~Octagon()
        {
            
        }

        public double calculateP()
        {
            double p = 0;
            for (int i = 0; i < 8; i+=2)
            {
                p += Math.Sqrt((Math.Pow((points[i + 1].X - points[i].X), 2) + (Math.Pow((points[i + 1].Y - points[i].Y), 2))));
            }
            return p;
        }

        public static double operator *(Octagon oct, Circle c)
        {
            double p = oct.calculateP() * c.calculateP();
            return p;
        }

        public static double operator *(Circle c, Octagon oct)
        {
            double p = oct.calculateP() * c.calculateP();
            return p;
        }

        public override void show(PaintEventArgs e)
        {
            e.Graphics.DrawPolygon(pen, points);
        }
    }
}