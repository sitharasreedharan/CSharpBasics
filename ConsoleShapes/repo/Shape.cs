using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShapes.repo
{
    class Shape : IShape
    {
        public void FindArea()
        {
            Console.WriteLine("No parameters passed");
        }

        public double FindArea(double radius)
        {
            return Math.PI* radius* radius;
        }

        public double FindArea(double length, double height, string shape)
        {
            if (string.Compare("triangle", shape, true) == 0)
                return .5 * length * height;
            else if (string.Compare("Rectangle", shape, true) == 0)
                return length * height;
            else
                return 0;

        }
    }
}
