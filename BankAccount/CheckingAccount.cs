using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Account
    {
        //Fields
        private string accountType = "Checking";

        //Constructors
        public CheckingAccount()
        {
            //default constructor
        }

        public CheckingAccount(string accountNumber, decimal accountBalance)
        {
            if(accountBalance < 0)
            {
                accountBalance = 0;
            }
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
        }

        //Methods
        public override void DisplayAccountBalance()
        {
            Console.WriteLine("\nChecking Account Balance: $" + accountBalance);
        }

        public override void DepositMoney(decimal depositAmount)
        {
            base.DepositMoney(depositAmount);
            Console.WriteLine("\nChecking Account Balance: $" + accountBalance);
        }

        public override void WithdrawMoney(decimal withdrawAmount)
        {
            decimal amount;
            while (withdrawAmount > accountBalance)
            {
                Console.Write("\nInsufficent Funds\n\nEnter a lesser amount $");
                decimal.TryParse(Console.ReadLine(), out amount);
                withdrawAmount = amount;
            }
            base.WithdrawMoney(withdrawAmount);
            Console.WriteLine("\nChecking Account Balance: $" + accountBalance);
        }
    }
}
