using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradeBook
{
    class gradeBook
    {
        static void Main(string[] args)
        {
            gradeBookTest myGradeBook = new gradeBookTest();

            Console.WriteLine("Enter the course name: ");
            string nameOfCourse = Console.ReadLine();
            Console.WriteLine();

            myGradeBook.displayMessage(nameOfCourse);
        }
    }
}
