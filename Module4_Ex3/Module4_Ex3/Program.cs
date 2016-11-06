using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using Switch statements.

namespace Module4_Ex3
{
    class Program
    {
        static void Main()
        {
            // Ask for user input.
            Console.Write("Please enter the number of a month (1 thru 12): ");

            // read user input.
             string strName = Console.ReadLine();

            // declare local varibles.
            string month = "";
            int nDays = 0; 

            // Start Switch statement.
            // list all 12 possiblities user can chose from
            switch(strName)
            {
                case "1":
                    month = "January";
                    nDays = 31;
                    break;

                case "2":
                    month = "February";
                    nDays = 29;
                    break;

                case "3":
                    month = "March";
                    nDays = 30;
                    break;

                case "4":
                    month = "April";
                    nDays = 30;
                    break;

                case "5":
                    month = "May";
                    nDays = 31;
                    break;

                case "6":
                    month = "June";
                    nDays = 30;
                    break;

                case "7":
                    month = "July";
                    nDays = 31;
                    break;

                case "8":
                    month = "August";
                    nDays = 31;
                    break;

                case "9":
                    month = "September";
                    nDays = 30;
                    break;

                case "10":
                    month = "October";
                    nDays = 31;
                    break;

                case "11":
                    month = "November";
                    nDays = 30;
                    break;

                case "12":
                    month = "December";
                    nDays = 31;
                    break;
                default: // catches unintended input.
                    month = "unknown entery";
                    nDays = -1;
                    break;

            }

            // Print result of user input.
            Console.WriteLine("The month {0} has {1} days.", month, nDays);

            // Hold window open.
            Console.ReadLine();
        }
    }
}
