using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program5
    {
        static void Main()
        {
            //pick a number 1-9
            Random r = new Random();
            int secretNum = r.Next(1, 10);

            // this doesn't work -> Random.Next

            bool correctGuess = false; //indicate that user has enter the correct guess
            //while user has not guess correctly
            while (correctGuess == false)
            {
                //ask user for a  guess
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                //if guess is correct
                if (input == secretNum.ToString())
                {
                    //congrats
                    Console.WriteLine("Congrats!");
                    correctGuess = true;
                }
                else
                {
                    //else
                    //say wrong guess
                    Console.WriteLine("Wrong guess. Try again.");
                }
            }

        }
    }
}
