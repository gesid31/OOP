using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimentionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the multidimentional Array Example: ");

            int[,] Rectangle = { { 1, 2, 3 }, { 4, 5, 6 } };

            int[][] jagged = { new int[] { 1, 2 },
            new int[] { 3},
            new int[] { 4, 5, 6} };


            outputArray(Rectangle);
            Console.WriteLine();
            outputArray(jagged);
        }

        public static void outputArray(int[,] array)
        {
            Console.WriteLine("output of Rectangle array");

            for (int rows = 0; rows < array.GetLength(0); rows++)
            {
                for (int columns = 0; columns < array.GetLength(1); columns++)
                {
                    Console.Write("{0} ",array[rows,columns]);
                }
                Console.WriteLine();
            }
        }

        public static void outputArray(int[][] array)
        {
            Console.WriteLine("Output of Jagged Arrays");

            foreach (int[] rows in array)
            {
                foreach (int element in rows)
                {
                    Console.Write("{0} ",element);
                }
                Console.WriteLine();
            }
        }
    }
}
