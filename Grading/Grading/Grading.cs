using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading
{
    class Grading
    {
        public string CourseGrade;

        public Grading(string name)
        {
            CourseGrade = name;
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Course \n{0}\n",CourseGrade);
        }

        public void DetermineGrading()
        {
            int total =0;
            int grading = 1;
            int grades;
            int average;

            while(grading <=10)
            {
                Console.WriteLine("Enter grade: ");
                grades = Convert.ToInt32(Console.ReadLine());
                total += grades;
                grading++;
            }

            average = total / 10;

            Console.WriteLine("Your Total grades are: {0}", total);

            Console.WriteLine("Your average Total is: {0:F}", average);
        }
    }
}
