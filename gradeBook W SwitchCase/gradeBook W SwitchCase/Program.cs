using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradeBook_W_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            grading classGrading = new grading("CS101 - Introduction to C# Programming");

            classGrading.displayMessage();
            classGrading.inputGrades();
            classGrading.displayResult();
            Console.WriteLine();
        }
    }
}
