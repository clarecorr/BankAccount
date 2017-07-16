using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {
        //Fields
        private decimal minimumBalance = 10;
        private string accountType = "Savings";

        //Property
        public double MinimumBalance { get; }

        //Constructors
        public SavingsAccount() //default constructor
        {
            this.accountBalance = minimumBalance; //never want saving account balance to be below minimum
        }

        public SavingsAccount(string accountNumber, decimal accountBalance) 
        {
            if(accountBalance < minimumBalance)
            {
                accountBalance = minimumBalance; 
            }
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
        }

        //Methods
        public override void DisplayAccountBalance()
        {
            Console.WriteLine("\nSavings Account Balance: $" + accountBalance);
        }

        public override void DepositMoney(decimal depositAmount)
        {
            base.DepositMoney(depositAmount);
            Console.WriteLine("\nSavings Account Balance: $" + accountBalance);
        }

        public override void WithdrawMoney(decimal withdrawAmount)
        {
            decimal amount;
            while (withdrawAmount > (accountBalance - minimumBalance))
            {
                Console.Write("\nInsufficent Funds (Savings Account has a minimum balance of ${0})\n\nEnter a lesser amount: $", minimumBalance);
                decimal.TryParse(Console.ReadLine(), out amount);
                withdrawAmount = amount;
            }
            base.WithdrawMoney(withdrawAmount);
            Console.WriteLine("\nSavings Account Balance: $" + accountBalance);
        }
    }
}
