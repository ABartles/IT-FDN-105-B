using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Calculate the factroial of a number provided by the user. 

namespace Assignment_4
{
    class Program
    {
        static void Main()
        {
            // initilize.
            int n;

            // start loop.
            // Identify if user input doesnt meet criteria. 
            while (true)
            {
                Console.Write("Please enter a non-negitive integer <= 100 for n: ");

                // Store users input into a varible of string type.
                string strn = Console.ReadLine();

                // converts string to int
                n = int.Parse(strn);

                // start error checking.
                if (n > 100)
                {
                    Console.WriteLine("Oops! Select a number less than 100.");
                    continue;
                }
                if (n < 1)
                {
                    Console.WriteLine("Oops! Select a number greater than or equal to 1.");
                    continue;
                }
                else
                {
                    break;
                }
            }

            // Initilize varibles
            int i = 1;
            double fact = 1;
                                     
            // Start for loop.
            while (i <= n)
            {
                fact = fact * i;
                Console.WriteLine("{0}! = {1}", i, fact);
                i++;
            }

            // Hold window open
            Console.ReadLine();

            // Print "Press any key to exit."
            Console.WriteLine("Press any key to exit.");
        }
    }
}
