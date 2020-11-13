using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x^2 + 2*x - th(x/2)\nEnter x value: ");
            string inputString = Console.ReadLine();
            int xValue = Convert.ToInt32(inputString);
            double result = Math.Pow(xValue, 2) + 2 * xValue - Math.Tanh(xValue / 2);
            if (xValue < 0)
            {
                Console.Write("("+ xValue +")" + "^2 + 2*" + "("+ xValue +")" + " - th(" + "(" + xValue +")" + "/2) = " + result);
            }
            else
            {
                Console.Write(xValue + "^2 + 2*" + xValue + " - th(" + xValue + "/2) = " + result);
            }
            
            Console.ReadKey();
        }
    }
}
