using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array before Modifyinh: {0}", array);

            foreach (int item in array)
            {
                Console.Write(" {0}", item);
            }

            ModifyArray(array);

            Console.WriteLine("\nArray after modification : ");
            foreach (int item in array)
            {
                Console.Write(" {0}",item);
            }

            ModifyElement( array [3] );

            Console.WriteLine("\nafter MOdifying Original value: {0}", array[3]);
        }

        public static void ModifyArray(int[] array2)
        {
            for (int counter = 0; counter < array2.Length; ++counter)
            {
                array2[counter] *= 2;
            }
        }
        public static void ModifyElement(int element)
        {
            element *= 2;
            Console.WriteLine("\n\nafter Modifing element the value is: {0}",element);
        }
    }
}
