using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShapes
{
    class Rectangle:Shapes
    {
        public double rlength;
        public double rheight;
        public double area;

        public Rectangle(double length, double height):base("Rectangle")
        {
            this.rlength = length;
            this.rheight = height;
        }
        public override double FindArea()
        {
            area = rlength * rheight;
            return area;
        }
    }
}