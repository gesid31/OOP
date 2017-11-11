using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradeBook_W_SwitchCase
{
    class grading
    {
        private int total;
        private int gradeCounter;
        private int aCount;
        private int bCount;
        private int cCount;
        private int dCount;
        private int fCount;

        public string CourseName { get; set; }

        public grading (string name)
        {
            CourseName = name;
        }

        public void displayMessage()
        {
            Console.WriteLine("Welcome to the Course:\n{0}\n",CourseName);
        }

        public void inputGrades()
        {
            int grades;
            string input;

            Console.WriteLine("{0}\n{1}","enter the integer for grades between 0-100",
                "press <ctrl>z and Enter to terminate for results:");
            input = Console.ReadLine();

            while(input != null)
            {
                grades = Convert.ToInt32(input);
                total += grades;
                gradeCounter++;

                IncreamentLettergradeCounter(grades);

                input = Console.ReadLine();
            }
        }

        public void IncreamentLettergradeCounter(int grades)
        {
            switch(grades/10)
            {
                case 9:
                case 10:
                    ++aCount;
                    break;

                case 8:
                    ++bCount;
                    break;

                case 7:
                    ++cCount;
                    break;

                case 6:
                    ++dCount;
                    break;

                default:
                    ++fCount;
                    break;
            }
        }

        public void displayResult()
        {
            if(gradeCounter != 0)
            {
                double average = (double)total / gradeCounter;

                Console.WriteLine("\ntotal of {0} grades is {1}",gradeCounter,total);
                Console.WriteLine("{0}\nA: {1}\nB: {2}\nC: {3}\nD: {4}\nF: {5}",
                    "the class grading are as follows",
                    aCount,
                    bCount,
                    cCount,
                    dCount,
                    fCount);

                if ( aCount > 5)
                {
                    Console.WriteLine("\nBonus for You");
                }
            }
        }
    }
}