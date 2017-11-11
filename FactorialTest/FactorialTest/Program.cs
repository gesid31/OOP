using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTest
{
    class Program
    {
        static void Main(string[] args)
        {
            for (long counter = 0; counter <= 10; counter++)
            {
                Console.WriteLine("{0}!= {1}", counter, Factorial( counter ));
            }
        }

        public static long Factorial(long number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}
