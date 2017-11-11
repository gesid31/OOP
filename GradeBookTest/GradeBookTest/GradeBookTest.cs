using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookTest
{
    class GradeBookTest
    {
        static void Main(string[] args)
        {
            GradeBook myGradeBook = new GradeBook();

            Console.WriteLine("Initial Coures: '{0}'\n",myGradeBook.CourseName);

            Console.WriteLine("Enter the course Name: ");
            myGradeBook.CourseName = Console.ReadLine();
            Console.WriteLine();

            myGradeBook.DisplayMessage();
        }
    }
}
