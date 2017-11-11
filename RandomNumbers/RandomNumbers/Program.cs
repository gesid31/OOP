using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int face;

            for(int counter = 0; counter <= 20; counter++)
            {
                face = randomNumber.Next(1, 7);
                Console.WriteLine("{0}",face );

                if (counter % 5 == 0)
                {
                    Console.WriteLine();
                }
            }

        }
    }
}
