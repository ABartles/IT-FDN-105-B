using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_EX1
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[] { 10, 15, 20, 25, 30, 35 };

            Console.Write("Enter a number: ");
            string str = Console.ReadLine();

            int num = int.Parse(str);  // convert input string into a number
            bool found = false;          // set a boolean flag

            foreach (int x in numbers) // use foreach to look for the number
            {
                // if number is found set found flag to true
                if (num == x)
                {
                    found = true;
                }
            }

            if (found == true) // if true, i.e. found the number, say Found the Number
            {
                Console.WriteLine("Found the number.");
            }
            else // if not true, did not find it, say Did not Find the Number
            {
                Console.WriteLine("Did not find the number.");
            }

            Console.ReadLine();
        }
    }
}
