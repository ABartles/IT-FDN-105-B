using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a numerical input.
            Console.Write("Please enter a non negitive/zero value: ");
           
            // Store the users input as a str type 
            string userstr = Console.ReadLine();
           
            // Convert character into an int. 
            int userint = int.Parse(userstr);

            // Set up a 2nd variable for the equation.
            int ans = userint;
            
            // Calculate the factorial of the users value.
            while (userint > 1)
            {
                ans = ans * (userint - 1);
                userint--;                
            }

            // Show the output of the factorial.
            Console.WriteLine("The factorial of {0} is: {1}", userstr, ans);
            
            // Hold the window open.
            Console.ReadLine();
        }
    }
}
