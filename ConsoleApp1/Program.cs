using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld objHello = new HelloWorld();
            objHello.Hello();

            Prime objprime = new Prime();
            objprime.PrintPrimes();

            ReverseString objRev = new ReverseString();
            objRev.Reverseastring();

            Palindrom objPal = new Palindrom();
            objPal.CheckForPalindrom();

            SmallestNo objSmall = new SmallestNo();
            objSmall.FindSmallestNo();

            //rectangle
            Rectangle objrect = new Rectangle();
            Console.WriteLine("Enter the length of rectangle");
            double length = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Enter the height of rectangle");
            double width = Convert.ToDouble(Console.ReadLine());
            objrect.FindRectangleArea(length, width);

            //Traingle
            Traingle objTri = new Traingle();
            objTri.GetDimensions();
            objTri.FindArea();

            //Circle
            Console.WriteLine("Enter the radius of the circle");
            double radius = Convert.ToDouble(Console.ReadLine());
            Circle objCircle = new Circle();
            objCircle.FindCircleArea(radius);
            objCircle.FindCriclePerimeter(radius);
            Console.ReadLine();


        }
    }
}
