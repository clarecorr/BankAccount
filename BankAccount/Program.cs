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
            Client client = new Client("Gerald Garner", "100100100", "100100101"); //instantiate a Client object
            CheckingAccount clientCheckingAccount = new CheckingAccount("100100100", 10000); //instantiate a CheckingAccount object
            SavingsAccount clientSavingsAccount = new SavingsAccount("100100101", 1000000);  //instantiate a SavingsAccount object

            int userInput;
            string accountChoice;
            decimal amount;

            //print menu
            Console.WriteLine("Welcome to the Bank\n\nMenu:\n\n1. View Client Information\n2. View Account Balance\n3. Deposit Funds\n4. Withdraw Funds\n5. Exit");
           
            //allow user to continue making selections until they enter "5" (exit)
            do
            {
                Console.WriteLine("\nEnter a selection 1-5 from the menu above");
                Int32.TryParse(Console.ReadLine(), out userInput);  
                
                switch (userInput)
                {
                    case 1: //client info
                        Console.WriteLine("\n" + client.ListClientInformation());
                        break;
                    case 2: //account balance
                        accountChoice = GetAccountChoice();
                        if (accountChoice == "a")
                        {
                            clientCheckingAccount.DisplayAccountBalance();
                        }
                        else
                        {
                            clientSavingsAccount.DisplayAccountBalance();
                        }
                        break;
                    case 3: //deposit funds
                        accountChoice = GetAccountChoice();
                        if (accountChoice == "a") //checking
                        {
                            amount = GetAmount(); 
                            clientCheckingAccount.DepositMoney(amount);
                        }
                        else //savings
                        {
                            amount = GetAmount(); 
                            clientSavingsAccount.DepositMoney(amount);
                        }

                        break;
                    case 4: //withdraw funds
                        accountChoice = GetAccountChoice();
                        if(accountChoice == "a") //checking
                        {
                            amount = GetAmount();
                            clientCheckingAccount.WithdrawMoney(amount);
                        }
                        else //savings
                        {
                            amount = GetAmount();
                            clientSavingsAccount.WithdrawMoney(amount);
                        }
                        break;
                    case 5: //exit
                        Console.WriteLine("Have a nice day!");
                        break;
                    default: //if user does not enter 1-5, they will be reminded to do so and loop will run again
                        Console.WriteLine("You must select a number 1-5");
                        break;
                }
            }
            while (userInput != 5);
         
        }

        static string GetAccountChoice() //Method to return which account user wants to access
        {
            string accountChoice;
            Console.WriteLine("\nSelect Account:\n\na.Checking Account\nb.Savings Account");
            accountChoice = Console.ReadLine().ToLower();
            while(accountChoice != "a" && accountChoice != "b")
            {
              Console.WriteLine("You must enter \"a\" for Checking or \"b\" for Savings");
              accountChoice = Console.ReadLine().ToLower();
            }
            return accountChoice;
        }
        

        static decimal GetAmount() //Method to return amount user wants to deposit or withdraw
        {
            decimal amount;
            Console.Write("\nEnter Amount: $");
            decimal.TryParse(Console.ReadLine(), out amount);
            return amount;
            //if the user enters a non-number, amount will be zero so will not affect their balance
            //did not want to overcomplicate by catching non-valid inputs and asking them to enter a valid number 
            //as this way it just won't affect their account
        }
    }
}
