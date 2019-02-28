using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleShapes.repo;

namespace ConsoleShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice=0;
            double area=0;
            
            while(choice!=4)
            {
                Console.WriteLine("Select a shape: 1.Circle,2.Rectangle,3.Traingle,4.Exit : ");
                choice = Convert.ToInt16(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Radius of the circle: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Circle cir = new Circle(radius);
                        area = cir.FindArea();
                        cir.DisplayArea(area);                      
                        break;
                    case 2:
                        Console.WriteLine("Length of rectangle is:");
                        double length = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Height of rectangle is: ");
                        double height = Convert.ToInt16(Console.ReadLine());
                        Rectangle rect = new Rectangle(length, height);
                        area = rect.FindArea();                     
                        rect.DisplayArea(area);                       
                        break;
                    case 3:
                        Console.WriteLine("Base length of traingle is: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Height of traingle: ");
                        double h = Convert.ToDouble(Console.ReadLine());
                        Traingle tr = new Traingle(b, h);
                        area = tr.FindArea();
                        tr.DisplayArea(area);                        
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Invalid choice ");
                        break;
                }

            }                 
            
            Console.ReadLine();

        }
    }
}
