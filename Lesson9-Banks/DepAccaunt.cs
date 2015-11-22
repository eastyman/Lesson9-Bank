using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson9_Banks
{
    public class DepAccount:Account,IProcentable
    {
        public double Rate { private set; get; }
        public DepAccount(double rate, double balance, string owner)
            : base(balance,  owner)
        {
            Rate = rate;
        }
        public void SetRate(double rate)
        {
            Rate = rate;
        }

        public void PercentAccural()
        {
            balance = balance + balance / 100 * Rate;
        }

    }
}
