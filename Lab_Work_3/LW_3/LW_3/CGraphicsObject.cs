using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LW_3
{
    public abstract class CGraphicsObject
    {
        protected List<List<double>> points;
        protected List<double> point;

        public abstract void show();
    }
}