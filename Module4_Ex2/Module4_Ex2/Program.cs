using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Find specified string.

namespace Module4_Ex2
{
    class Program
    {
        static void Main()
        {
            // Ask for user input.
            Console.Write("Enter a person's full name: ");

            // Read user input and set to string.
            string str = Console.ReadLine();

            // check if user input ends with "Smith" & print result.
            if (str.EndsWith(" Smith"))
            {
                Console.WriteLine("You found a Smith!");
            }
            else 
            {
                Console.WriteLine("No Smith here!");            
            }
            // Hold window open.
            Console.ReadLine();
        }
    }
}
