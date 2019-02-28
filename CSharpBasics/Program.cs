using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
           // var cust1 = new Customer();
            //cust1.id = 1;
            //Console.WriteLine(cust1.Name);
            //Console.WriteLine(cust1.id);
            var ord1 = new Order();
           // cust1.Ordrs.Add(ord1);
            //Console.ReadLine();
            //var Person = new Person
                            //{
                            //    name="sit",
                            //    id=1

                            //};

        }
    }

  

public class NumberGenerator
    {
        int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

        public int GetNumber(int index)
        {
            if (index < 0 || index >= numbers.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return numbers[index];
        }
    }



}
