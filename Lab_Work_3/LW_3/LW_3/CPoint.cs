using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LW_3
{
    public class CPoint : CGraphicsObject
    {
        public List<double> Point
        {
            get{ return point; }
            set{ point = value;}
        }

        public CPoint()
        {
        }

        ~CPoint()
        {
            
        }

        public override void show()
        {
            Console.Write("This class is the inheritor of CGraphicsObject. It is point with coordinates: ");
            int point = 1;
            int counter = 0;
            foreach (double coord in Point)
            {
                if (counter % 2 == 0)
                {
                    Console.Write("point " + point + ": ");
                    point += 1;
                }
                Console.Write(coord + ", ");
                counter += 1;

            }
        }
    }
}