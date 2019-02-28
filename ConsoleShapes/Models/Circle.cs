using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleShapes
{
    class Circle : Shapes

    { 
        public double cradius;
        public Circle(double radius):base("Circle")
        {
            this.cradius = radius;
        }
        public override double FindArea()
        {
            double area = Math.PI * cradius * cradius;
            return area;
        }
    }
}
