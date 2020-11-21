using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Octagon figure = new Octagon();
            CPoint t = new CPoint();
            List<double> point = new List<double> ();
            List<List<double>> points = new List<List<double>>();
            for (int p = 0; p < 8; p++)
            {
                Console.Write("Enter x for " + Convert.ToInt32(p + 1) + " coordinate:");
                point.Add(Convert.ToDouble(Console.ReadLine()));
                Console.Write("Enter y for " + Convert.ToInt32(p + 1) + " coordinate:");
                point.Add(Convert.ToDouble(Console.ReadLine()));
                t.Point = point;
                points.Add(t.Point);
            }
            figure.Points = points;
            figure.show();
            t.show();
            Console.ReadKey();
        }
    }
}
