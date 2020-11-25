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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxCircle_Paint(object sender, PaintEventArgs e)
        {
            Circle circle = new Circle(new Pen(Color.Red, 2), 10, 10, 100, 100);
            circle.show(e);

        }

        private void pictureBoxOct_Paint(object sender, PaintEventArgs e)
        {
            Point[] octagonPoints = { new Point(100, 25), new Point(150, 25),  new Point(200, 50), new Point(200, 75), new Point(150, 100),
                                      new Point(100, 100), new Point(50, 75), new Point(50, 50), new Point(100, 25) };
            Octagon octagon = new Octagon(new Pen(Color.Green, 2), octagonPoints);
            octagon.show(e);
        }

        private void perimeterButton_Click(object sender, EventArgs e)
        {
            Point[] octagonPoints = { new Point(100, 25), new Point(150, 25),  new Point(200, 50), new Point(200, 75), new Point(150, 100),
                                      new Point(100, 100), new Point(50, 75), new Point(50, 50), new Point(100, 25) };
            Octagon octagon = new Octagon(new Pen(Color.Green, 2), octagonPoints);
            Circle circle = new Circle(new Pen(Color.Red, 2), 10, 10, 100, 100);
            double p = octagon * circle;
            pLabel.Text = "Perimeter = " + Convert.ToString(p);
        }
        private void buttonOct_Click(object sender, EventArgs e)
        {
            pictureBoxOct.Refresh();
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            pictureBoxCircle.Refresh();
        }
    }
}
