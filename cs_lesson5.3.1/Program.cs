using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lesson5._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedIntArray;
            jaggedIntArray = new int[3][] {
                new int[] { 1, 2, 3 }, new int[] { 1 }, new int[] { 1, 2 } };

            /*
             int[][] jaggedIntArray = { 
             new int[] { 1, 2, 3 }, new int[] { 1 }, new int[] { 1, 2 } };
             
             */

            int[][] divisors1To10 = { new int[] { 1 },
            new int[] { 1, 2 },
            new int[] { 1, 3 },
            new int[] { 1, 2, 4 },
            new int[] { 1, 5 },
            new int[] { 1, 2, 3, 6 },
            new int[] { 1, 7 },
            new int[] { 1, 2, 4, 8 },
            new int[] { 1, 3, 9 },
            new int[] { 1, 2, 5, 10 } };
            foreach (int[] divisorsOfInt in divisors1To10)
            {
                foreach (int divisor in divisorsOfInt)
                {
                    Console.WriteLine(divisor);
                    
                }
                
            }
            Console.ReadKey();



        }
    }
}
