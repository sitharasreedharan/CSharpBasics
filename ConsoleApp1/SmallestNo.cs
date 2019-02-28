using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SmallestNo
    {
        public void FindSmallestNo()
        {
            //Console.WriteLine("Enter the no of elements to find the smallest no:");
            //int noOfElements = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Enter elements");
            //int[] inputs = new int[noOfElements];   
            //for (int j = 0; j <= noOfElements-1; j++)
            //{
            //   inputs[j] = Convert.ToInt16(Console.ReadLine());
            //}
            Console.WriteLine("Enter a comma separated list of numbers to find the smallest no:");
            string inp = Console.ReadLine(); //"2,3,5,1"
            string [] input = inp.Split(','); 

            int smallest= Convert.ToInt16(input[0]);            
            for (int i = 0; i <= input.Length-1; i++)
            {
                  int no = Convert.ToInt16(input[i]);
                  if (smallest > no)
                    smallest = no;
            }
            Console.WriteLine("Smallest number is {0}", smallest);

        }
    }
}
