using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson9_Banks
{
    public class CurrAccaunt:Account,IAccessable
    {
        public CurrAccaunt(double balance, string owner) : base(balance, owner) { }
        public void PutAmount(double amount)
        {
            balance = balance+amount;
        }
        public void GetAmount(double amount)
        {
            if (balance - amount >= 0)
            {
                balance = balance - amount;
            }
        }
    }
}
