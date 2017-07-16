using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Account
    {
        private string accountType = "Checking";

        public CheckingAccount()
        {
            //default constructor
        }

        public override void DepositMoney(double depositAmount)
        {
            base.DepositMoney(depositAmount);
            Console.WriteLine("\nChecking Account Balance: $" + accountBalance);
        }

        public override void WithdrawMoney(double withdrawAmount)
        {
            double amount;
            while (withdrawAmount > accountBalance)
            {
                Console.Write("\nInsufficent Funds\n\nEnter a lesser amount $");
                double.TryParse(Console.ReadLine(), out amount);
                withdrawAmount = amount;
            }
            base.WithdrawMoney(withdrawAmount);
            Console.WriteLine("\nChecking Account Balance: $" + accountBalance);
        }
    }
}
