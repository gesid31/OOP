using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis
{
    class Program
    {
        static void Main(string[] args)
        {
            int pass = 0;
            int fail = 0;
            int counter = 1;
            int result;
                                
            while(counter <= 10)
            {
                Console.WriteLine("Enter 1:pass 2:fail : ");
                result = Convert.ToInt32(Console.ReadLine());

                if (result == 1)
                {
                    pass ++;
                }
                else
                {
                    fail++;
                }
                counter++;
            }
            Console.WriteLine("students passed: {0} failed:{1}", pass, fail);

            if(pass > 8)
            {
                Console.WriteLine("bonus for instructor");
            }
        }
    }
}
