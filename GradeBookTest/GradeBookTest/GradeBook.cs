using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookTest
{
    class GradeBook
    {
        private string courseName;

        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the course For\n{0}", courseName);
        }
    }
}
