using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShapes
{
    interface IShape
    {
        void FindArea();
        double FindArea(double radius);
        double FindArea(double length,double width,string shape);        
        
       
    }
}
