using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {
        private double minimumBalance;
        private string accountType = "Savings"; 

        public double MinimumBalance { get; } = 10; //set minimum balance to $10, cannot set b/c minimum balance should not change

        public SavingsAccount()
        {
            //default constructor
        }

        public override void DepositMoney(double depositAmount)
        {
            base.DepositMoney(depositAmount);
            Console.WriteLine("\nSavings Account Balance: $" + accountBalance);
        }

        public override void WithdrawMoney(double withdrawAmount)
        {
            double amount;
            while (withdrawAmount > (accountBalance - 10))
            {
                Console.Write("\nInsufficent Funds (Savings Account has a minimum balance of $10)\n\nEnter a lesser amount: $");
                double.TryParse(Console.ReadLine(), out amount);
                withdrawAmount = amount;
            }
            base.WithdrawMoney(withdrawAmount);
            Console.WriteLine("\nSavings Account Balance: $" + accountBalance);
        }
    }
}
