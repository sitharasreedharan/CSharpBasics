using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Test
{
    class TraingleArea
    {
        public double tbase;
        public double theight;
        private double area;
        
        
        public TraingleArea()
        {
            Console.WriteLine("Base of traingle: ");
            tbase=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height of traingle: ");
            theight = Convert.ToDouble(Console.ReadLine());
            area = .5 * tbase * theight;
            Console.WriteLine("Area is {0} ",area);
            
        }       
    }
}
