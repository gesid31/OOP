using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 6; i++)
            {
                if (i % 2 != 0 && (i == 5 || i == 1))
                {
                    Console.WriteLine("{0}{0}{0}", num);
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine("{0} {0}", num);
                }
            }
            /*else
            {
                Console.WriteLine("Invalid Age {0}",age);
            }
*/
            /*
                        Console.WriteLine("Enter the fourth Number: ");
                        int fourthNumber = Convert.ToInt32(Console.ReadLine());

                        Double Avg = (double)(firstNumber + secondNumber + thirdNumber + fourthNumber)/ 4;

                        Console.WriteLine("Average of the Given Numbers: {0:F}", Avg);*/


        }
    }
}
