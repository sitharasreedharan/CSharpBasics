using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShapes
{
    public abstract class Shapes
    {
        private string shapename { get; set; }
        private double area { get; set; }

        public Shapes(string name)
        {
            this.shapename = name;
        }

        public abstract double FindArea();
        public void DisplayArea(double area)
        {
            Console.WriteLine("Area of {0} is {1}", shapename, area);
        }
        
    }
}
