using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Quiz
    {
        static void Main(string[] args)
        {
            //asking for input
            Console.WriteLine("Welcome to ISS Gadget Shop.");
            Console.Write("Number of items to purchase: ");
            string input = Console.ReadLine();

            int qty = Int32.Parse(input);

            //calculate the total amount
            double amount = qty * 500;

            //calculate the discount
            double discount = 0;
            if (amount > 6000)
            {
                discount = 0.08;
            } else if (amount > 3000)
            {
                discount = 0.05;
            } else if (amount > 2000)
            {
                discount = 0.03;
            }

            //re-calculate the amount
            double totalAmount = amount - (discount*amount);

            //display amount
            Console.WriteLine("Please pay {0:C}", amount);
        }
    }
}
