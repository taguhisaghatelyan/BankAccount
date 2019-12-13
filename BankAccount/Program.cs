using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new Bank_Account(1000.0);
            //Test not valid InerestRate
            try
            {
                account1.InterestRate = 23.1;
                Console.WriteLine($"Account1's balance is` {account1.Balance} with {account1.InterestRate} Interestrate");
            }
            catch (InvalidInterestrateException e)
            {
                Console.WriteLine(e.Message);
            }
            //Test for negative amount and add money
            try
            {
                account1.Deposit(-500.1);
                Console.WriteLine(account1.Balance);
            }
            catch (InvalidAmountException e)
            {
                Console.WriteLine(e.Message);
            }
            //Test for Removing money
            try
            {
                account1.Withdraw(1500);
                Console.WriteLine(account1.Balance);
            }
            catch (InvalidAmountException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidAmountForRemovingMoneyException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
