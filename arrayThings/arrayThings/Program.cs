using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayThings
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 2, 3, 4, 5 };

            int[] firstArrayCopy = firstArray;

            Console.WriteLine("Array before passing through the Value Type: ");

            for (int i = 0; i < firstArray.Length; ++i)
            {
                Console.Write("{0} ",firstArray[i]);
            }

            firstDouble(firstArray);

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("{0} ", firstArray[i]);
            }

            if (firstArray == firstArrayCopy)
            {
                Console.WriteLine("\nand both are similar");
            }
            else
            {
                Console.WriteLine("Are Different");
            }


            int[] secondArray = { 1, 2, 3 };

            int[] secondArrayCopy = secondArray;

            Console.WriteLine("\nArray before passing through the Reference Type: ");
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write("{0} ", secondArray[i]);
            }

            secondDouble(ref secondArray);

            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write("{0} ", secondArray[i]);
            }

            if (secondArray == secondArrayCopy)
            {
                Console.WriteLine("\n and both are similar");
            }
            else
            {
                Console.WriteLine("\n And both are Different");
            }
        }

        public static void firstDouble(int[] Array)
        {
            Console.WriteLine("\narray after passing through Value Type: ");
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] *= 2;
            }
            Array = new int[] { 11, 12, 13};
            
        }

        public static void secondDouble(ref int[] array)
        {
            Console.WriteLine("\nArray After passing through Reference Type: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;
            }

            array = new int[] { 11, 12, 13 };
        }
    }
}
