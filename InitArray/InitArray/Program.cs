using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { };//declaring an array named array

            // creating a space for array and initializing to default zeros
            array = new int[5];//5 int elements

            Console.WriteLine("{0} {1,8}","Index","Value");// headings and spacing(8)

            //output each array element's value
            for( int counter = 0; counter < array.Length; counter++ )
            {
                Console.WriteLine("{0,3} {1,8}", counter, array[counter]);
            }
        }//end Main
    }//end class init array
}
