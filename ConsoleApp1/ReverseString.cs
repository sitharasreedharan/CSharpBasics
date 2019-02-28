using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ReverseString
    {
        public void Reverseastring()
        {

            Console.Write("Enter a string to Reverse: ");
            string str=Console.ReadLine();
            char[] arr1=str.ToArray();
            string newstr = "";
            for (int i = arr1.Length-1; i >=0; i--)
            {
                newstr = newstr + arr1[i];                
            }
            Console.WriteLine(newstr);
        }
    }
}

