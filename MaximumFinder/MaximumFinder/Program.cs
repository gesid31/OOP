 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers, each with pressing enter");
            double Number1 = Convert.ToDouble(Console.ReadLine());
            double Number2 = Convert.ToDouble(Console.ReadLine());
            double Number3 = Convert.ToDouble(Console.ReadLine());

            double result = Maximum (Number1, Number2, Number3);
            Console.WriteLine("Maximum amongst given numbers is: "+ result);

        }

        public static double Maximum(double x,double  y,double  z)
        {
            double  maximumValue = x;
            if(maximumValue < y)
            {
                maximumValue = y;
            }

            if(maximumValue < z)
            {
                maximumValue = z;
            }

            return maximumValue;
        }
    }
}
