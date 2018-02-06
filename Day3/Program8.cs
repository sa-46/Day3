using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program8
    {
        static void Main()
        {
            string s = "$$$****%%%abcdef$$$%%%***";

            char[] c = new char[] { '$', '*' };

            string r = s.Trim(c);

            Console.WriteLine(r);
        }
    }
}
