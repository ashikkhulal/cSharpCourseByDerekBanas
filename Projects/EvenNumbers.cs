using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            Console.WriteLine("Even numbers less than 100 (skips 100) are:");

            while (i <= 100)
            {
                if (i % 2 == 1)
                {
                    i++;
                    continue;
                }

                if (i == 100)
                {
                    break;
                }
                Console.WriteLine(i);
                i++;
            }
            
        }
    }
}