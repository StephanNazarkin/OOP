using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LW_3
{
    public class Octagon : CPoint
    {

        public List<List<double>> Points
        {
            get{ return points;}
            set{ points = value;}
        }

        public Octagon()
        {
        }

        ~Octagon()
        {
           
        }

        public override void show()
        {
            Console.Write("This class is the inheritor of CPoint. It is octagon with points: ");
            int idx = 0;
            foreach (List<double> point in Points)
            {
                Console.Write("[" + point[idx] + ";" + point[idx + 1] + "]"+ "\n");
                idx += 2;
            }
        }
    }
}