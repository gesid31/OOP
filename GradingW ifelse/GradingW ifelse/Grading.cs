using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingW_ifelse
{
    class Grading
    {
        public string CourseInfo;
        
        public Grading(string name)
        {
            CourseInfo = name;
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the course \n{0}\n", CourseInfo);
        }
        public void DetermineClassAverage()
        {
            int total;
            int grading;
            int grade;
            double average;

            total = 0;
            grading = 0;

            Console.WriteLine("enter grade or -1 to quit: ");
            grade = Convert.ToInt32(Console.ReadLine());

            while (grade != -1)
            {
                total += grade;
                grading++;
                Console.WriteLine("enter grade or -1 to quit: ");
                grade = Convert.ToInt32(Console.ReadLine());
            }

            if(grading != 0)
            {
                average = (double)total / grading;
                Console.WriteLine("total number of {0} Grades entered is {1}",grading,total);
                Console.WriteLine("Class Average is {0:F}",average);
            }
            else
            {
                Console.WriteLine("No grades Were entered");
            }

        }

    }
}
