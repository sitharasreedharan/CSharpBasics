using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Prime
    {
        public void PrintPrimes()
        {
            Console.WriteLine("Printing all Prime nos below 100");
            int Prime = 100;
            for (int i = 2; i <= Prime; i++)
            {
                bool flag = false;
                for (int j = 2; j < i; j++)
                {
                    if(i % j ==0)
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag == false)
                    Console.WriteLine(i);

            }
        }
    }
}
