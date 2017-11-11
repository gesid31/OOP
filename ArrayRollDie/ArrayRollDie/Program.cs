using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRollDie
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int[] frequency = new int[7];

            for (int roll = 0; roll <= 6000000; ++roll)
            {
                ++frequency[randomNumber.Next(1, 7)];
            }

            Console.WriteLine("{0} {1,10}", "Face","Frequency");

            for (int face = 1; face < frequency.Length; ++face)
            {
                Console.WriteLine("{0,4} {1,10}",face,frequency[face]);
            }
        }
    }
}
