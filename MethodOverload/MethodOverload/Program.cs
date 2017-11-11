using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Square of the Interger 7 is: {0}", Square (7));
            Console.WriteLine("Square of the Double 7 is: {0}", Square (7.5));
        }//main method

        public static int Square (int IntValue)
        {
            Console.WriteLine("calling from the interger value : {0}", IntValue);
            return IntValue* IntValue;
        }//end of interger value
        
        public static double Square (double doubleValue)
        {
            Console.WriteLine("calling from the Double value : {0}", doubleValue);
            return doubleValue * doubleValue;
        }//end of double process
    }//end of method overload
}
