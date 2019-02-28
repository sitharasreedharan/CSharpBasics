using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Traingle
    {
        public double b;
        public double h;
        
        public void GetDimensions( )
        {
            Console.WriteLine("Please enter base of traingle: ");
            b = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("Please enter height of traingle: ");
            h= Convert.ToDouble(Console.ReadLine());
                            

        }

        public void FindArea()
        {
            double area = .5 * b * h;
            Console.WriteLine("Area of triangle is {0} ",area);
        }
    }
}
