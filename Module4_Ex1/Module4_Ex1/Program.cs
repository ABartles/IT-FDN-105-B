using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Find the ASCII value of a character.

namespace Module4_Ex1
{
    class Program
    {
        static void Main()
        {
            // Have user enter a character.
            Console.Write("Enter a character: ");

            // Read the user input & set to string type.
            string str = Console.ReadLine();

            // Converts character to Unicode.
            char ch = str[0];

            // Set as int.
            int ascii = ch;

            Console.WriteLine("ASCII = {0}", ascii);

            // Hold window open.
            Console.ReadLine();
        }
    }
}
