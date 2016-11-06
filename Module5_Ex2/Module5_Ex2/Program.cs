using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Foreach example
// Create an array of numbers and find the max & min values of the array.

namespace Module5_Ex2
{
    class Program
    {
        static void Main()
        {
            // Initilize vaible, define array, set to integer.
            int[] aNum = new int[] { 0, 4, 6, 95, -25, -2, 60, 8 };
            
            // Initilize varibles and set to integer.
            int Min;
            int Max;

            // Set Max and Min to the # in the first pos of the array.
            Max = aNum[0];
            Min = aNum[0];

            // Start foreach loop.
            // loops through each pos in the array
            // If the # in the pos is < min or > max it will redefine as that #.
            foreach (int x in aNum)
            {
                if (x < Min)
                {
                    Min = x;
                }
                if (x > Max)
                {
                    Max = x;
                }
            }

            // Print output.
            Console.WriteLine("The Min value is: {0}", Min);
            Console.WriteLine("The Max value is: {0}", Max);

            // Hold window open.
            Console.ReadLine();
        }
    }
}
