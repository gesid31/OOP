using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrest
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amount;
            decimal principle = 1000;
            double rate=0.05;
            
            Console.WriteLine("Year{0,20}","Amount on deposit");

            for (int year = 1;year <=10; ++year)
            {
                amount = principle * ((decimal)Math.Pow(1.0 + rate, year));
                Console.WriteLine("{0,4} {1,20:C}",year,amount);
            }
        }
    }
}
