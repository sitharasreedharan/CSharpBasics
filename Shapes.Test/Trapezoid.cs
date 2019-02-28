using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Test
{
    class Trapezoid
    {
        public double TrapezoidArea(double base1,double base2,double height)
        {           
            return ((base1 + base2) / 2) * height;
        }
    }
}
