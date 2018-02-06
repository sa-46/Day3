using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program9
    {
        static void Main()
        {
            string s = "Hello world!";
            string r = "";
            //to print each character on a single line

            //repeat i from 0 to the (length of s) - 1
            //for (int i = 0; i <= s.Length - 1; i++)
            for (int i = s.Length - 1; i >= 0; i--) //to do it in reverse
            {
                //if the i-th character of s is not a space then
                string x = s.Substring(i, 1);
                if (x != " ")
                {
                    //print the i-th character of s
                    Console.WriteLine(x);
                    //add the i-th character of s to r
                    r = r + x;
                }
            }

            Console.WriteLine(r);
        }
    }
}
