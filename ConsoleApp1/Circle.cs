using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Circle
    {
        
        public void FindCircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of the Circle is {0} ", area);
            
        }
        public void FindCriclePerimeter(double radius)
        {
            double perimeter = 2*Math.PI * radius;
            Console.WriteLine("Perimeter of the Circle is {0} ", perimeter);
        }
    }
}
