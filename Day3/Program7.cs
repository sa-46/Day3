using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program7
    {
        static void Main()
        {
            double length;
            bool successfulParse;
            do
            {
                Console.Write("Please enter the length in cm (positive number):");
                string input = Console.ReadLine();
                //length = Double.Parse(input);

                successfulParse = Double.TryParse(input, out length);

            } while (length < 0 || (successfulParse == false));

            double inch = length / 2.54;

            Console.WriteLine("The length is {0} inch", inch);
        }
    }
}
