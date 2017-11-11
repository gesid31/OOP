using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalGrade
{
    class GradeBook
    {
        private int[,] grades;
        public string courseName { get; set; }

        public GradeBook(string name, int[,] grade)
        {
            grades = grade;
            courseName = name;
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the course:\n{0}\n",courseName);
        }

        public void ProcessGrades()
        {
            outputGrades();

            Console.WriteLine("\n{0} {1}\n{2} {3}\n",
                "Minimum Value amongst the Grades are", minumumGrade(),
                "Maximum Value amongst the Grades are", maximumGrade());

            ouputBarChart();

        }

        public void outputGrades()
        {
            Console.WriteLine("The Grades of every student are: \n");
            Console.Write("                 ");

            for (int Test = 0; Test < grades.GetLength(1); Test++)
            {
                Console.Write("Test {0}   ", Test + 1);
            }
            Console.WriteLine("Average");

            for (int student = 0; student < grades.GetLength(0); ++student)
            {
                Console.Write("Student {0:D2}",student + 1);

                for (int grade = 0; grade < grades.GetLength(1); ++grade)
                {
                    Console.Write("{0,9} ",grades[student,grade]);
                }
                Console.WriteLine("{0,10:F} ", GetAvg(student));

            }

        }

        public int minumumGrade()
        {
            int lowValue = grades[0, 0];

            foreach (int grade in grades)
            {
                if (grade < lowValue)
                {
                    lowValue = grade;
                }   
            }
            return lowValue;
        }


        public int maximumGrade()
        {
            int highvalue = grades[0, 0];

            foreach (int grade in grades)
            {
                if (grade > highvalue)
                {
                    highvalue = grade;
                }
            }
            return highvalue;
        }

        public void ouputBarChart()
        {
            Console.WriteLine("Output BarChart is as follows: ");

            int[] frequency = new int[11];

            foreach (int grade in grades)
            {
                ++frequency[grade / 10];
            }

            for (int count = 0; count < frequency.Length; ++count)
            {
                if (count == 10)
                {
                    Console.Write("  100: ");
                }
                else
                {
                    Console.Write("{0:D2}-{1:D2}: ",
                        count * 10, count * 10 + 9);
                }

                for (int stars = 0; stars < frequency[count]; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        public double GetAvg(int student)
        {
            int amount = grades.GetLength(1);
            int total = 0;

            for (int exam = 0; exam < amount; ++exam)
            {
                total += grades[student,exam];
            }
            return (double)total / amount;
        }
    }
}
