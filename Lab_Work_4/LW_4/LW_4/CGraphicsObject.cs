using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_4
{
    public abstract class CGraphicsObject
    {
        protected Point point;
        protected Point[] points;
        protected Pen pen;
        protected int x;
        protected int y;
        protected int width;
        protected int height;
        protected double perimeter;

        public virtual void show(PaintEventArgs e)
        {

        }
    }
}