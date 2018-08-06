using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: use different constructors for accounts.
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount("Vacation");
            BankAccount account3 = new BankAccount("Kitchen Remodel", new DateTime(2018, 2, 22), 8900.00);


            Console.WriteLine(account1.GetAccountInfo());
            Console.WriteLine(account2.GetAccountInfo());
            Console.WriteLine(account3.GetAccountInfo());

            Console.ReadLine();
        }
    }
}
