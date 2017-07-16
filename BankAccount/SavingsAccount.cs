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

        public double MinimumBalance { get; } = 10; 

        public SavingsAccount()
        {
            //default constructor
        }
    }
}
