using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program2
    {
        static void Main()
        {
            //a program that ask for password
            //the password is ISS
            //if the person give wrong password 3 times, 
            //the system will be locked.

            bool correctPwd = false;
            //repeat 3 times
            //for (int i = 1; i <= 3; i++)
            for (int i = 0; i < 3; i++)
            {
                //  ask for password
                Console.Write("Enter password: ");
                string input = Console.ReadLine();

                //  if password correct
                if (input == "ISS")
                {
                    //    set the flag to true
                    correctPwd = true;
                    //    say Congrats
                    Console.WriteLine("Congratulation!");
                    //    exit repetition
                    break;
                }
                else
                {
                    //  else 
                    //    say Password Incorrect
                    Console.WriteLine("Password Incorrect");
                }
            }

            if (correctPwd == false)
            {
                Console.WriteLine("Game Over.");
            }
        }
    }
}
