using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scope
{
    class Program
    {
        private static int x = 1;

        static void Main(string[] args)
        {
            int x = 5;

            Console.WriteLine("as you see the value of X before assigning/changing {0}", x);

            useLocalVariable();

            useStaticVariable();

            useLocalVariable();

            useStaticVariable();

            Console.WriteLine("\nlocal X main method variable is x {0}", x);
        }

        public static void useLocalVariable()
        {
            int x = 25;
            Console.WriteLine( "Considering local variable x {0}", x);
            ++x;
            Console.WriteLine("After Multiplying {0}", x);
        }

        public static void useStaticVariable()
        {
            Console.WriteLine("with the method staticvariable x is {0}", x);
            x *= 10;
            Console.WriteLine("After the change staticVariable is {0}", x);
        }
    }
}
