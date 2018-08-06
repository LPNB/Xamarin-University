using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Name = "Bank Account";

            BankAccount myWallet = new BankAccount(2000);
            myWallet.Name = "My Wallet";

            // string to convert to int
            string userInput;
            // variable to store converted int value
            int num;

            do
            {
                Console.WriteLine("Menu options:" +
                    "\n1) Deposit to bank" +
                    "\n2) Withdraw from bank" +
                    "\n3) Display balances" +
                    "\n4) Quit" +
                    "\n----------------------------------------------------\n");

                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out num))
                { /* if conversion is succesful, store the value in num variable */ }
                
                switch (num)
                {
                    case 1:
                        {
                            depositOrWithdraw(myWallet, bankAccount);
                            break;
                        }
                    case 2:
                        {
                            depositOrWithdraw(bankAccount, myWallet);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Account balances:");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{bankAccount.Name}: {bankAccount.AmountOfMoney.ToString("C")}");
                            Console.WriteLine($"{myWallet.Name}: {myWallet.AmountOfMoney.ToString("C")} \n");
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input. Make another selection. \n");
                            break;
                        }
                }
                Console.ResetColor();
            } while (num != 4);
        }

        private static void depositOrWithdraw(BankAccount fromAccount, BankAccount toAccount)
        {
            Console.WriteLine("Enter transfer amount:");

            double amount = double.Parse(Console.ReadLine());

            if (fromAccount.Withdraw(amount))
            {
                toAccount.Desposit(amount);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{fromAccount.Name}: {fromAccount.AmountOfMoney.ToString("C")}");
                Console.WriteLine($"{toAccount.Name}: {toAccount.AmountOfMoney.ToString("C")} \n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Insufficient funds. Cannot complete transaction. \n");
            }
        }
    }
}
