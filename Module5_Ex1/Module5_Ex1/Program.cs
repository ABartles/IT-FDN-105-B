using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For Loops.
// Write a program that calc the averge of numbers input by the user.

namespace Module5_Ex1
{
    class Program
    {
        static void Main()
        {
            // initilize varibles.
            float fsum = 0.0f;
            float favg = 0;

            // start for loop to collect user input.
            // limits to 10 entries by incrementing x.
            for (int x = 1; x <= 10; x++)
            {
                Console.Write("Please enter number {0} of 10: ", x); // Asks for input.
                string strnum = Console.ReadLine(); // Collects user input and sets to string.
                float n = float.Parse(strnum); // revoes white space, assigns to n and sets to float.
                fsum = fsum + n; // Sums user input.
            }
            
            // calculate the average of the users inputs.
            favg = fsum / 10;

            // Print out the result.
            Console.WriteLine("The average of the numbers given is: {0}", favg);

            // Hold window open.
            Console.ReadLine();
        }
    }
}
