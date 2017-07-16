using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        private string name;
        private string checkingAccountNumber;
        private string savingsAccountNumber;

        //need 3 properties
        public string Name { get; }
        public string CheckingAccountNumber { get; }
        public string SavingsAccountNumber { get; }

        public Client()
        {
            //default constructor
        }

        public Client(string name, string checkingAccountNumber, string savingsAccountNumber)
        {
            this.name = name;
            this.checkingAccountNumber = checkingAccountNumber;
            this.savingsAccountNumber = savingsAccountNumber;
        }

        //need 1 method
        public string ListClientInformation()
        {
            return ("Name: " + name + "\nChecking Account Number: " + checkingAccountNumber + "\nSavings Account Number: " +savingsAccountNumber); 
        }
    }
}
