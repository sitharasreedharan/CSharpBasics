using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangle
    {
        public void FindRectangleArea(double length, double width)
        {
            double area = length * width;
            Console.WriteLine("Area of Rectangle is {0} ",area);
        }
    }
}