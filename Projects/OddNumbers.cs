using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = 1;
            Console.WriteLine("Odd numbers less than 100 are:");
            while (i <= 100)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
		}
	}
}