using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program1
    {
        static void Main()
        {
            //counting starting from 0 in variable i, each time increase by 1,  
            // while i<10
            // we want i to go from 0 .. 9
            //for (int i = 0; i < 10; i++) //initialization ; condition; increment/decrement
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 10; i <= 15; i++) 
            //{
            //    Console.WriteLine(i);
            //}

            //for (int j = 20; j >= 10; j--)
            //{
            //    Console.WriteLine(j);
            //}

            for (int i = 0; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
