using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Palindrom
    {
        public void CheckForPalindrom()
        {
            Console.WriteLine("Enter a string to check ehether it is palindrom: ");
            string pal = Console.ReadLine();
            char[] palRev = pal.ToCharArray();
            Array.Reverse(palRev);
            string rev = new string(palRev);
            bool ispal = pal.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (ispal == true)
                Console.WriteLine("string is a palindrom");
            else
                Console.WriteLine("string is not palindrom");

        }
    }
}
