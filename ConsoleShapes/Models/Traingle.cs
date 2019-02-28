using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShapes
{
    class Traingle: Shapes
    {
        public double tbase;
        public double theight;
        private double area;
        //private double MyProperty2 { get { return 1;  } }
        //private double MyProperty4 { get; set; } = 1;
        //private readonly double MyProperty3;

        public Traingle(double baselen, double height): base("Traingle")
        {
            this.tbase = baselen;
            this.theight=height;
        }

        public override double FindArea()
        {
            area = .5 * tbase * theight;
            return area;
        }
    }
}
