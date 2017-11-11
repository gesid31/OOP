using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayGradesBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gradesArray = { 87, 98, 100, 65, 54, 73, 63, 94, 92, 54 };

            ArrayGradeBookTest myGradeBook =
                new ArrayGradeBookTest("CS101: Introduction To C# Programming",gradesArray);


            myGradeBook.displayName();
            myGradeBook.ProcessGrades();


        }
    }
}
