using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson9_Banks
{
    public interface IAccessable
    {
        void PutAmount(double amount);
        void GetAmount(double amount);
    }
}
