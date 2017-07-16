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
        protected decimal accountBalance;
        protected string accountType;  //instructions specify each account should have a type...

        //Properties
        public string AccountNumber { get; }
        public decimal AccountBalance
        {
            get
            {
                accountBalance = Math.Round(accountBalance, 2); //Want to return the balance rounded to 2 decimals for money
                return accountBalance;
            }
        }
        public string AccountType { get; }

        //Constructor
        public Account()
        {
            //default constructor
        }

        //Methods
        public virtual void DepositMoney(decimal depositAmount)
        {
            accountBalance += depositAmount;
            accountBalance = Math.Round(accountBalance, 2);
        }

        public virtual void WithdrawMoney(decimal withdrawAmount)
        {
            accountBalance -= withdrawAmount;
            accountBalance = Math.Round(accountBalance, 2);
        }
    }
}
