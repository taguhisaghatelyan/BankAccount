using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Bank_Account
    {
        public double Balance{get;set;}
       
        private double interestRate;
        //Interestrate of the account must be between 0.0 to 22.0
        public double InterestRate
        {           
            set
            {
                if (InterestRate <= 0.0 || InterestRate >= 22.0)
                {
                    //An exception  thrown when a bank account is defined with illegal interest rate.
                    throw new InvalidInterestrateException("InterestRate must be from 0.0 to 22.0");
                }
                else
                {
                    this.interestRate = InterestRate;
                }
            }
            get
            {
                    return this.interestRate;         
            }
        }
        public Bank_Account(double balance)
        {          
            this.Balance = balance;
        }
        
        //removing specified amount of money from the account
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException("Amount must be positive" );
            }
            else if (Balance < amount)
            {
                throw new InvalidAmountForRemovingMoneyException("Not sufficient funds for this withdrawal");
            }
            else
            {
                this.Balance -= amount;
            }
        }
        // adding specified amount of money to the account
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException("Amount of money must be positive");
            }
            else
            {
                this.Balance += amount;
            }
        }
    }
}
