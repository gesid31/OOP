using System;

namespace RectangleApplication
{
    class Rectangle
    {
        Double length;
        Double width;
        public void AcceptDetails()
        {
            length = 4.5;
            width = 3.5;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length = {0}", length);
            Console.WriteLine("Width = {0}", width);
            Console.WriteLine("GetArea = {0}", GetArea());
        }
    }//end of Rectangle Class

       class ExecuteRectangle
    {
        static void Main(String[] args)
        {
            Rectangle r = new Rectangle();
            r.AcceptDetails();
            r.GetArea();
            r.Display();
            Console.ReadLine();
        }
    }//End of Execute Rectangle Class.
        

}