using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_6
{
    class Program
    {
        delegate double CalcP();
        static void Main(string[] args)
        {
            int[] points = { 100, 25, 150, 25, 200, 50, 200, 75, 150, 100, 100, 100, 50, 75, 50, 50, 100, 25 };
            int radius = 50;
            CalcP perimeter;
            Octagon oct = new Octagon(points);
            Circle circle = new Circle(radius);
            perimeter = oct.calculateP;
            Console.Write("Perimeter of an octagon = " + perimeter() + "\n");
            perimeter = circle.calculateP;
            Console.Write("Perimeter of a circle = " + perimeter() + "\n");

            ArrayList listOfClasses = new ArrayList();
            listOfClasses.Add(oct);
            listOfClasses.Add(circle);
            Console.WriteLine("Elements in collection: ");
            foreach (object o in listOfClasses)
            {
                Console.WriteLine(o);
            }
            Console.ReadKey();
        }
    }
}
