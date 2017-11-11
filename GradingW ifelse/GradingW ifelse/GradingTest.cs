using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingW_ifelse
{
    class GradingTest
    {
        static void Main(string[] args)
        {
            Grading myGrades = new Grading("CS101 - Introduction to C# Programming");

            myGrades.DisplayMessage();
            myGrades.DetermineClassAverage();
            Console.ReadLine();
        }
    }
}
