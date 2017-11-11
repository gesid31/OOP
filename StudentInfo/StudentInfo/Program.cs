using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region INTIALIZATION
            int paper, regno, total, gradeCounter;
            string name;
            decimal average;

            Console.WriteLine("Enter the Registration Number:");
            regno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name:");
            name = Convert.ToString(Console.ReadLine());
            #endregion

            #region CALCULATIONS
            total = 0;
            gradeCounter = 0;

            Console.Write("Enter the grades or -1 to terminate: ");
            paper = Convert.ToInt32(Console.ReadLine());

            while (paper != -1)
            {
                total += paper;
                gradeCounter++;

                Console.Write("Enter the grades or -1 to terminate: ");
                paper = Convert.ToInt32(Console.ReadLine());
                

            }
            #endregion

            #region RESULT

            Console.Clear();
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Registration Number: {0}", regno);
            Console.WriteLine("\nStudent Name: {0}", name);
            Console.WriteLine("*********************************************************");
            Console.WriteLine("\ntotal Number of Grades entered: {0}", gradeCounter);

            if (gradeCounter != 0)
            {
                average = (decimal)total / gradeCounter;

                Console.WriteLine("\naverage of the given Student: {0:F} ", average);
            }
            Console.WriteLine();
            #endregion
        }
    }
}
