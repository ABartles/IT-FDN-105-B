using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_Ex3
{
    class BankAccount
    {
        // create the balance field
        private decimal balance;

        //create a constructor

        public BankAccount()
        {
            //initialize balance in constructor
            balance = 0
        }
        //create the deposit function

        public void Deposit(//code)
    {
            // code here to calculate new balance after deposit
        }

        // create the withdrawal function
        public void Withdrawal(// code) 
    {
            // code here to calculate new balance after withdrawal
        }

        //create an accessing function to find what your current balance is
        public decimal GetBalance()  // returns the balance in decimal
        {
            //code here to deliver balance to end-user
        }
    }

    class Test
    {
        static void Main()
        {
            BankAccount acct = new BankAccount();

            acct.Deposit(200m);
            acct.Withdrawal(40m);

            Console.WriteLine("The final balance is {0}", acct.GetBalance());

            Console.ReadLine();
        }
    }
}
