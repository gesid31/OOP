using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("please enter a value: " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());  
            }
            Console.WriteLine();
            Console.WriteLine("******************");
            foreach (var i in arr)
            {
              Console.Write(i.ToString() + " ");
            }
            Console.WriteLine();
            Console.WriteLine("******************");

            int maximum = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maximum)
                {
                    maximum = arr[i];
                }
            }
            Console.WriteLine("Out the values provided in an array, the maximum number is: {0}",maximum);
            Console.ReadLine();
        }
    }
}
