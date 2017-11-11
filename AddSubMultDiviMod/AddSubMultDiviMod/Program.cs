using System;


namespace AddSubMultDiviMod
{

    public class gotcha
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int sub(int a, int b)
        {
            return a - b;
        }

        public int mult(int a,int b)
        {
            return a * b;
        }

        public double divi(double a , double b)
        {
            return a / b;
        }

        public double mod(double a,double b)
        {
            return a % b;
        }
   }
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            double fresult;

            gotcha obj = new gotcha();

            result = obj.add(145, 12);
            Console.WriteLine("Addition of both numbers is {0}",result);

            result = obj.sub(145, 12);
            Console.WriteLine("Substration of both numbers is {0}", result);

            result = obj.mult(145, 12);
            Console.WriteLine("Multiplication of both numbers is {0}", result);

            fresult= obj.divi(14.5, 22.1);
            Console.WriteLine("Division of both numbers is {0}", fresult);

            fresult = obj.mod(145, 12);
            Console.WriteLine("Modulus of both numbers is {0}", fresult);

        }
    } 
}