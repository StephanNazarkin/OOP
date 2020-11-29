using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LW_6
{
    public class Octagon : CGraphicsObject, IOctagon
    {
        public int[] Points
        {
            get { return points; }
            set { points = value; }
        }

        public Octagon()
        {
        }

        public Octagon(int[] p)
        {
            points = p;
        }

        ~Octagon()
        {
        }

        public override void show()
        {
            Console.Write("Class octagon inherits from a CGraphicsObject");
        }

        public override double calculateP()
        {
            double p = 0;
            for (int i = 0; i < 16; i += 4)
            {
                p += Math.Sqrt((Math.Pow((points[i + 2] - points[i]), 2) +
               (Math.Pow((points[i + 3] - points[i + 1]), 2))));
            }
            return p;
        }

        void IOctagon.show()
        {
            Console.Write("It is an interface method. Class octagon inherits from a CGraphicsObject");
        }

        double IOctagon.calculateP()
        {
            Console.Write("It is an interface method.");

            double p = 0;
            for (int i = 0; i < 16; i += 4)
            {
                p += Math.Sqrt((Math.Pow((points[i + 2] - points[i]), 2) +
               (Math.Pow((points[i + 3] - points[i + 1]), 2))));
            }
            return p;
        }
    }
}