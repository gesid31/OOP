using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers_W_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int Frequency1 = 0;
            int Frequency2 = 0;
            int Frequency3 = 0;
            int Frequency4 = 0;
            int Frequency5 = 0;
            int Frequency6 = 0;

            int face;

            for( int counter= 0; counter <=600000; counter++)
            {
                face = randomNumber.Next(1, 7);

                switch (face)
                {
                    case 1:
                        ++Frequency1;
                        break;
                    case 2:
                        ++Frequency2;
                        break;
                    case 3:
                        ++Frequency3;
                        break;
                    case 4:
                        ++Frequency4;
                        break;
                    case 5:
                        ++Frequency5;
                        break;
                    case 6:
                        ++Frequency6;
                        break;
                }
            }

            Console.WriteLine("Face\tFrequency");

            Console.WriteLine("1\t{0}\n2\t{1}\n3\t{2}\n4\t{3}\n5\t{4}\n6\t{5}\n",
                Frequency1,Frequency2,Frequency3,Frequency4,Frequency5,Frequency6);
        }
    }
}
