using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummingTheNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 0, 0, 0, 0, 0, 1, 2, 4, 3, 2 };

            for( int counter = 0; counter <array.Length; counter++)
            {

                if(counter == 10)
                {
                    Console.WriteLine(" 100: ");
                }
                else
                {
                    Console.WriteLine("{0:D2}-{1:D2}: ",
                        counter * 10,counter * 10 + 9);
                }

                for(int stars = 0; stars < array[counter]; stars++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
