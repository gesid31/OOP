using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamArray
{
    class Program
    {
        public static double Average(params double[] Numbers)
        {
            double  total = 0.0;

            foreach (double d in Numbers)
            {
                total += d;
            }

            return total / Numbers.Length;
        } 
        static void Main(string[] args)
        {
            double d1 = 100.22;
            double d2 = 12.322;
            double d3 = 3.12;
            double d4 = 5623.12;

            Console.WriteLine(
                "d1 = {0:F1}\nd2 = {1:F1}\nd3 = {2:F1}\nd4 = {3:F1}\n", d1, d2, d3, d4);

            Console.WriteLine("Avg of d1,d2 and d3 = {0}", Average(d1, d2, d3));

            Console.WriteLine("Avg of d2 and d4 = {0}", Average(d2, d4));

            Console.WriteLine("Avg of d1 and d2 = {0}", Average(d1,d2));
        }
    }
}
