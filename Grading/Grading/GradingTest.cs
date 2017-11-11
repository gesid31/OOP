using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading
{
    class GradingTest
    {
        static void Main(string[] args)
        {
            Grading myGrading = new Grading("CS101 - Introduction to Programming");

            myGrading.DisplayMessage();

            myGrading.DetermineGrading();
        }
    }
}
