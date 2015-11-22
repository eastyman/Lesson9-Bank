using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson9_Banks
{
    public class CardAccount: DepAccount, IProcentable
    {
        public CardAccount(double rate, double balance, string owner) : base(rate, balance, owner) { }        
    }
}
