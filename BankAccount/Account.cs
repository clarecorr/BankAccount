using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        //Fields (all protected as this is parent class)
        protected string accountNumber; //used string b/c an account number should be manipulated 
        protected double accountBalance;
        protected string accountType;  //instructions specify each account should have a type...

        //Properties
        public string AccountNumber { get; }
        public double AccountBalance
        {
            get
            {
                return Math.Round(accountBalance, 2); //Want to return the balance rounded to 2 decimals b/c money
            }
        }
        public string AccountType { get; }

        //Constructor
        public Account()
        {
            //default constructor
        }

        //Methods
        public virtual void DepositMoney(double depositAmount)
        {
            accountBalance += depositAmount;
        }

        public virtual void WithdrawMoney(double withdrawAmount)
        {
            accountBalance -= withdrawAmount;
        }
    }
}
