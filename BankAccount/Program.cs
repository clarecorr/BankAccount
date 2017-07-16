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
            Client client = new Client("Gerald Garner", "100100100", "100100101");
            CheckingAccount clientCheckingAccount = new CheckingAccount();
            SavingsAccount clientSavingsAccount = new SavingsAccount();

            int userInput;
            string accountChoice;

            Console.WriteLine("Welcome to the Bank\n\nMenu:\n\n1. View Client Information\n2. View Account Balance\n3. Deposit Funds\n4. Withdraw Funds\n5. Exit");
           

            do
            {
                Console.WriteLine("\nEnter a selection 1-5 from the menu above");
                Int32.TryParse(Console.ReadLine(), out userInput);
                
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("\n" + client.ListClientInformation());
                        break;
                    case 2:
                        Console.WriteLine("\nSelect Account:\n\na.Checking Account\nb.Savings Account");
                        accountChoice = Console.ReadLine().ToLower();
                        while(accountChoice != "a" && accountChoice != "b")
                        {
                            Console.WriteLine("You must enter \"a\" or \"b\"");
                            accountChoice = Console.ReadLine().ToLower();
                        }
                        if (accountChoice == "a")
                        {
                            Console.WriteLine("\nChecking Account Balance: " + clientCheckingAccount.AccountBalance);
                        }
                        else
                        {
                            Console.WriteLine("\nSavings Account Balance: " + clientSavingsAccount.AccountBalance);
                        }
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        Console.WriteLine("Have a nice day!");
                        break;
                    default:
                        Console.WriteLine("You must select a number 1-5");
                        break;
                }
            }
            while (userInput != 5);
        }
    }
}
