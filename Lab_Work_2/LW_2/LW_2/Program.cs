using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace LW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallelogram par = new Parallelogram();
            par.setASide(10);
            par.setAlphaAngle(60);
            par.setAHeight(30);
            par.calculateArea();
        }
    }
}
