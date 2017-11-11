using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayGradesBook
{
    class ArrayGradeBookTest
    {
        #region Initializing
        private int[] grades;

        public string CourseName { get; set; }

        public ArrayGradeBookTest(string name, int[] gradesArray)
        {
            CourseName = name;
            grades = gradesArray;
        }//end of array test
        #endregion

        #region Display Name
        public void displayName()
        {
            Console.WriteLine("Welcome To the gradeBook for\n{0}!\n",CourseName );
        }//end of display
        #endregion

        #region ProcessGrades
        public void ProcessGrades()
        {
            OutputGrades();

            Console.WriteLine("\nClass total Average {0:F}",GetAvg());

            Console.WriteLine("LowestGrade is {0}\nHighest Grade{1}",
                getMinimum(),getMaximum());

            OutputBarChart();
        }//end of process grades
        #endregion

        #region GetAvg  
        public double GetAvg()
        {
            int total = 0;

            foreach (int grade in grades)
            {
                total += grade;
            }

            return (double) total / grades.Length;

        }//end of get avg
        #endregion

        #region Get Minimum
        public int getMinimum()
        {
            int lowerGrade = grades[0];

            foreach (int grade in grades)
            {
                if (grade < lowerGrade)
                {
                    lowerGrade = grade;
                }
            }

            return lowerGrade;
        }
        #endregion

        #region GetMaximum
        public int getMaximum()
        {
            int higherGrade = grades[0];

            foreach (int grade in grades)
            {
                if (grade > higherGrade)
                {
                    higherGrade = grade;
                }
            }
            return higherGrade;
        }//end of Maximum grade
        #endregion

        #region output barChart
        public void OutputBarChart()
        {
            Console.WriteLine("Grades Distrubution: ");

            int[] frequency = new int[11];

            foreach (int grade in grades)
            {
                ++frequency[grade/10];
            }
            for (int count = 0; count < frequency.Length; count++)
            {
                if (count == 10)
                {
                    Console.Write(" 100: ");
                }
                else
                {
                    Console.Write("{0:D2}-{1:D2}: ",
                        count * 10, count * 10 + 9);
                }

                for (int stars = 0; stars < frequency[count]; ++stars)
                {
                    Console.Write( "*"  );

                    Console.WriteLine();
                }
            }
        }//end of output barchart
        #endregion

        #region OutputGrades
        public void OutputGrades()
        {
            Console.WriteLine("The Grades Are : \n");
            for (int student = 0; student < grades.Length; student++)
            {
                Console.WriteLine("Student {0,2}: {1,3}",
                    student + 1, grades[student]);
            }
        }//end of output Grades
        #endregion

    }
}
