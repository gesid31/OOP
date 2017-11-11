using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatePowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Power(10) = {0}", Power(10) );
            Console.WriteLine("Power(2,10) = {0}", Power(2,10));
        }

        public static int Power(int baseValue, int exponentValue = 2)
        {
            int result = 1;

            for (int i = 1; i <= exponentValue; i++)
            {
                result *= baseValue;
            }
            return result;
        }
    }
}
