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

    public class CPoint : CGraphicsObject
    {
        public Point Point
        {
            get { return point; }
            set { point = value; }
        }

        public CPoint()
        {
            
        }

        public CPoint(Point p)
        {
            point = p;
        }


        ~CPoint()
        {
            
        }

        public override void show( PaintEventArgs e)
        {
        }
    }
}