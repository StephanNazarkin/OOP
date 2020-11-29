using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LW_6
{
    public class Circle : CGraphicsObject, ICircle
    {
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle()
        {
        }

        public Circle(int r)
        {
            radius = r;
        }

        ~Circle()
        {
        }

        public override void show()
        {
            Console.Write("Class circle inherits from a CGraphicsObject");
        }

        public override double calculateP()
        {
            double p = 2 * Math.PI * radius;
            return p;
        }

        void ICircle.show()
        {
            Console.Write("It is an interface method. Class circle inherits from a CGraphicsObject");
        }

        double ICircle.calculateP()
        {
            Console.Write("It is an interface method.");
            double p = 2 * Math.PI * radius;
            return p;
        }
    }
}