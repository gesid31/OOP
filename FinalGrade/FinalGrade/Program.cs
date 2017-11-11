using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grades = { { 95, 68, 64},
                              { 56, 98, 100},
                              { 90, 79, 45},
                              { 56, 94, 97},
                              { 100, 57, 44},
                              { 69, 85, 95},
                              { 91, 84, 100},
                              { 75, 74, 55},
                              { 56, 77, 73},
                              { 94, 89, 67} };

            GradeBook myGradeBook = new GradeBook("CS101: Introduction to the C# Programming Language",grades);

            myGradeBook.DisplayMessage();

            myGradeBook.ProcessGrades();

        }
    }
}
