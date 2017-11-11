using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPoll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] responses = { 1, 2, 3, 4, 5, 1, 3, 1, 2, 9};
            int[] frequency = new int[6];

            for(int answer = 0; answer < responses.Length; ++answer)
            {
                try
                {
                    ++frequency[responses[answer]];
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("responses [{0}] = {1}",
                        answer, responses[answer]);
                }
            }
            Console.WriteLine("{0} {1,10}", "Rating","Frequency" );

            for (int rating = 0; rating < frequency.Length; ++rating)
            {
                Console.WriteLine("{0,6} {1,10}",rating, frequency[rating]);
            }
        }
    }
}
