using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson9_Banks
{
    public class Account
    {
        protected double balance;
        protected string owner;
        public Account(double balance, string owner)
        {
            this.balance = balance;
            this.owner = owner;
        }

        public void AccountState()
        {
            Console.WriteLine("Состояние счета: ");
            Console.WriteLine("Владелец счета: " + owner + " сумма " + balance);
        }

        public double CloseAccount()
        {
            double retBalance = balance;
            balance = 0.0;
            return retBalance;
        }

        public string ReturnOwner()
        {
            return owner;
        }
    }
}
