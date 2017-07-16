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

            do
            {
                Console.WriteLine("Menu");
                userInput = int.Parse(Console.ReadLine());
                if(userInput == 1)
                {

                }
                if (userInput == 2)
                {

                }
                if (userInput == 3)
                {

                }
                if (userInput == 4)
                {

                }
            }
            while (userInput != 5);
        }
    }
}
