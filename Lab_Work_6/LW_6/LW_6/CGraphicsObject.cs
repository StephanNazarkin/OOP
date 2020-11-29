using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace LW_6
{
    public abstract class CGraphicsObject
    {
        protected int[] points;
        protected int radius;


        public abstract void show();

        public abstract double calculateP();
    }
}