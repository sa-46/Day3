using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program3
    {
        static void Main()
        {
            //repeat i from 1 to 7
            for (int i=1; i<=7; i++)
            {
                //print "*" i times

                //repeat j from 1 to i
                for (int j = 1; j <= i; j++)
                {
                    //print *
                    Console.Write("*");
                }
                //change line
                Console.WriteLine();
            }
        }
    }
}
