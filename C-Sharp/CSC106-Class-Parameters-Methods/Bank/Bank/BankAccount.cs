using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankAccount
    {
        public string Name { get; set; }
        public double AmountOfMoney
        {
            get; private set;
        }

        public BankAccount(double startingAmount = 1200)
        {
            AmountOfMoney = startingAmount;
        }

        public void Desposit(double amount)
        {
            AmountOfMoney += amount;
        }

        public bool Withdraw(double amountToWithdraw)
        {
            if (AmountOfMoney < amountToWithdraw)
                return false;

            AmountOfMoney -= amountToWithdraw;
            return true;
        }
    }
}
