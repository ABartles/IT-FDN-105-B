using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Datatype class execise 
// Calculate the polynomial 

namespace Module3_Ex1
{
    class Program
    {
        static void Main()
        {
            // Ask for an input
            Console.Write("Please type in a value for x: ");

            // Read the input and save into a string type.
            string str = Console.ReadLine();

            // Convert the string type into an integer type.
            int x = int.Parse(str);

            // Calculate the polynomial and save it into an integer type.
            int iResult = (int)((4 * x * x) + (3 * x) - 7);

            // Show the result of the polynomial equation.
            Console.WriteLine("The calculated value for 4x^2+3x-7 is {0}", iResult);

            // Hold the screen open.
            Console.ReadLine();
        }
    }
}
