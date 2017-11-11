using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 10;
            int z;

            Console.WriteLine("Original Value of Y: {0}", y);
            Console.WriteLine("Original Value of Z : Initialized\n");

            SquareRef(ref y);
            SquareOut(out z);

            Console.WriteLine("value of Y after Reference Edit: {0}",y);
            Console.WriteLine("value of z after Out Edit: {0}\n", z);

            square(y);
            square(z);
            Console.WriteLine("value of y after square: {0}", y);
            Console.WriteLine("value of z after square: {0}", z);

        }

        static void SquareRef(ref int x)
        {
            x = x * x;
        }
        static void SquareOut(out int x)
        {
            x = 21;
            x = x * x;
        }
        static void square(int x)
        {
            x = x * x;
        }
    }
}
